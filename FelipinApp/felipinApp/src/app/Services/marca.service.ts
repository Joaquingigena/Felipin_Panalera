import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment.development';
import { categoria } from '../Interfaces/categoria';
import { marca } from '../Interfaces/marca';

@Injectable({
  providedIn: 'root'
})
export class MarcaService {

  private http= inject(HttpClient);
  private urlApi = environment.apiUrl + "/Marca/"
  
  
  constructor() { }


  public listar():Observable<marca[]>{
    return this.http.get<marca[]>(`${this.urlApi}Listar`);
  }

  public crear(marca :marca){
    return this.http.post(`${this.urlApi}Agregar`,marca);
  }

  public eliminar(id:number){
    return this.http.delete(`${this.urlApi}Eliminar/${id}`);
  }

  public modificar(id:number,marca:marca){
    return this.http.put(`${this.urlApi}Modificar/${id}`,marca);
  }
}
