import { Injectable,inject } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class UtilidadService {

  snack= inject(MatSnackBar);

  constructor() { }

   mostrarAlerta(mensaje:string,tipo:string){
    this.snack.open(mensaje,tipo,{
    horizontalPosition:"end",
    verticalPosition:"top",
    duration: 3000,
  });
}
}
