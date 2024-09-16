import { Component, inject } from '@angular/core';
import { ReactiveFormsModule,FormBuilder,Validators, FormControl } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { RouterLink } from '@angular/router';
import { InputImgComponent } from "../../../Compartidos/input-img/input-img.component";
import { Producto } from '../../../Interfaces/producto';

@Component({
  selector: 'app-crear-producto',
  standalone: true,
  imports: [MatButtonModule, RouterLink, MatFormFieldModule, ReactiveFormsModule, MatInputModule, InputImgComponent],
  templateUrl: './crear-producto.component.html',
  styleUrl: './crear-producto.component.css'
})
export class CrearProductoComponent {

  private formBuilder= inject(FormBuilder);

  formularioProducto= this.formBuilder.group({
    nombre: ["",Validators.required],
    descripcion: ["",Validators.required],
    precio: [0,Validators.required],
    img: new FormControl<File | null>(null)
  });

  crearProducto(){

    if(this.formularioProducto.invalid){
      return
    }

    const producto= this.formularioProducto.value as Producto;

    console.log(producto);
  }

  archivoSeleccionado(file: File){
    this.formularioProducto.controls.img.setValue(file);
  }
}
