import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Shippers } from '../../models/shippers.model';
import { ShippersService } from '../../services/shippers.service';

@Component({
  selector: 'app-shippers',
  templateUrl: './shippers.component.html',
  styleUrls: ['./shippers.component.css'],
})
export class ShippersComponent implements OnInit {

  modo = 'Guardar';
  id: number;
  listaTransportes: any[];
  formulario: FormGroup;

  constructor(private formBuilder: FormBuilder, private shippersService: ShippersService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.obtenerTransportes();
    this.iniciarFormulario();
  }

  iniciarFormulario() {
    this.formulario = this.formBuilder.group({
      empresa: ['', [Validators.required, Validators.maxLength(40)]],
      telefono: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(16)]],
    });
  }

  cancelarFormulario() {
    if (this.modo == 'Editar') {
      this.modo = 'Guardar'
    }
    this.formulario.reset();
  }

  obtenerTransportes() {
    this.shippersService.getTransportes().subscribe(data => {
      this.listaTransportes = data;
    }, error => {
      this.toastr.error('¡Ups! Algo salió mal...', 'Error');
    });
  }

  guardarTransporte() {
    var transporte = new Shippers();
    transporte.company = this.formulario.get('empresa').value;
    transporte.phone = this.formulario.get('telefono').value;

    if ((this.id == undefined)) {
      this.shippersService.postTransporte(transporte).subscribe(data => {
        this.toastr.success('¡Transporte guardado con éxito!', 'Transporte guardado');
        this.formulario.reset();
        this.obtenerTransportes();
      }, error => {
        this.toastr.error('¡Ups! Algo salió mal...', 'Error');
      });
    } else {
      transporte.id = this.id;
      this.shippersService.putTransporte(transporte.id, transporte).subscribe(data => {
        this.toastr.info('¡Transporte editado con éxito!', 'Transporte editado');
        this.formulario.reset();
        this.modo = 'Guardar';
        this.id = undefined;
        this.obtenerTransportes();
      }, error => {
        this.toastr.error('¡Ups! Algo salió mal...', 'Error');
      });
    }
  }

  editarTransporte(transporte: any) {
    this.modo = 'Editar';
    this.id = transporte.ShipperID;
    this.formulario.patchValue({
      empresa: transporte.CompanyName,
      telefono: transporte.Phone,
    });
  }

  eliminarTransporte(id: number) {
    this.shippersService.deleteTransporte(id).subscribe(data => {
      this.toastr.error('¡Transporte eliminado con éxito!', 'Transporte eliminado');
      this.obtenerTransportes();
    }, error => {
      this.toastr.error('¡Ups! Algo salió mal...', 'Error');
    });
  }

  get f() { return this.formulario.controls; }
}
