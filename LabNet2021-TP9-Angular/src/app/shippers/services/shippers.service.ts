import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Shippers } from '../models/shippers.model';

@Injectable({
  providedIn: 'root',
})
export class ShippersService {

  private url = environment.api + 'shippers/';

  constructor(private http: HttpClient) { }

  getTransportes(): Observable<any> {
    return this.http.get(this.url);
  }

  postTransporte(transporte: Shippers): Observable<any> {
    return this.http.post(this.url, transporte);
  }

  putTransporte(id: number, transporte: Shippers): Observable<any> {
    return this.http.put(this.url + id, transporte);
  }

  deleteTransporte(id: number): Observable<any> {
    return this.http.delete(this.url + id);
  }
}
