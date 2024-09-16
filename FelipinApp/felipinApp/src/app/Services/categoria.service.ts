import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { categoria } from '../Interfaces/categoria';
import { environment } from '../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  private http= inject(HttpClient);
  private urlApi = environment.apiUrl + "/Categoria/"
  
  
  constructor() { }


  public listar():Observable<categoria[]>{
    return this.http.get<categoria[]>(`${this.urlApi}Listar`);
  }

  public crear(categoria :categoria){
    return this.http.post(`${this.urlApi}Agregar`,categoria);
  }

  public eliminar(id:number){
    return this.http.delete(`${this.urlApi}Eliminar/${id}`);
  }
}
