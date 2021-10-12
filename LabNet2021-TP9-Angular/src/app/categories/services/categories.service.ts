import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Categories } from '../models/categories.model';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  private url = environment.api + 'categories/';

  constructor(private http: HttpClient) { }

  getCategorias(): Observable<any> {
    return this.http.get(this.url);
  }

  postCategoria(categoria: Categories): Observable<any> {
    return this.http.post(this.url, categoria);
  }

  putCategoria(id: number, categoria: Categories): Observable<any> {
    return this.http.put(this.url + id, categoria);
  }

  deleteCategoria(id: number): Observable<any> {
    return this.http.delete(this.url + id);
  }
}
