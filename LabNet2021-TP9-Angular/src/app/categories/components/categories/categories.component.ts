import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Categories } from '../../models/categories.model';
import { CategoriesService } from '../../services/categories.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {

  modo = 'Guardar';
  id: number;
  listaCategorias: any[];
  formulario: FormGroup;

  constructor(private formBuilder: FormBuilder, private categoriesService: CategoriesService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.obtenerCategorias();
    this.iniciarFormulario();
  }

  iniciarFormulario() {
    this.formulario = this.formBuilder.group({
      categoria: ['', [Validators.required, Validators.maxLength(15)]],
      descripcion: ['', Validators.required]
    });
  }

  cancelarFormulario() {
    if (this.modo == 'Editar') {
      this.modo = 'Guardar'
    }
    this.formulario.reset();
  }

  obtenerCategorias() {
    this.categoriesService.getCategorias().subscribe(data => {
      this.listaCategorias = data;
    }, error => {
      this.toastr.error('¡Ups! Algo salió mal...', 'Error');
    });
  }

  guardarCategoria() {
    var categoria = new Categories();
    categoria.category = this.formulario.get('categoria').value;
    categoria.description = this.formulario.get('descripcion').value;

    if ((this.id == undefined)) {
      this.categoriesService.postCategoria(categoria).subscribe(data => {
        this.toastr.success('¡Categoría guardada con éxito!', '¡Categoría guardada');
        this.formulario.reset();
        this.obtenerCategorias();
      }, error => {
        this.toastr.error('¡Ups! Algo salió mal...', 'Error');
      });
    } else {
      categoria.id = this.id;
      this.categoriesService.putCategoria(categoria.id, categoria).subscribe(data => {
        this.toastr.info('¡Categoría editada con éxito!', '¡Categoría editada');
        this.formulario.reset();
        this.modo = 'Guardar';
        this.id = undefined;
        this.obtenerCategorias();
      }, error => {
        this.toastr.error('¡Ups! Algo salió mal...', 'Error');
      });
    }
  }

  editarCategoria(categoria: any) {
    this.modo = 'Editar';
    this.id = categoria.CategoryID;
    this.formulario.patchValue({
      categoria: categoria.CategoryName,
      descripcion: categoria.Description,
    });
  }

  eliminarCategoria(id: number) {
    this.categoriesService.deleteCategoria(id).subscribe(data => {
      this.toastr.error('¡Categoría eliminada con éxito!', 'Categoría eliminada');
      this.obtenerCategorias();
    }, error => {
      this.toastr.error('¡Ups! Algo salió mal...', 'Error');
    });
  }

  get f() { return this.formulario.controls; }
}
