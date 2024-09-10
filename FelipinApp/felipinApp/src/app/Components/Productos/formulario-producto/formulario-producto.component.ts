import { Component, inject } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-formulario-producto',
  standalone: true,
  imports: [MatButtonModule,RouterLink,MatFormFieldModule,ReactiveFormsModule,MatInputModule],
  templateUrl: './formulario-producto.component.html',
  styleUrl: './formulario-producto.component.css'
})
export class FormularioProductoComponent {

  formBuilder= inject(FormBuilder);

  form= this.formBuilder.group({
    nombre: ["",Validators.required],
    descripcion: [""],
    precio: ["",Validators.required],
    img: [""],
    idMarca: ["",Validators.required],
    idCategoria: ["",Validators.required]
  });
}
