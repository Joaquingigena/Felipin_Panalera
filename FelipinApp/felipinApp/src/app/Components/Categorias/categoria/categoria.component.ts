import { Component, inject, OnInit } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, RequiredValidator, Validators } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import{Router, RouterLink} from '@angular/router';
import { CategoriaService } from '../../../Services/categoria.service';
import { categoria } from '../../../Interfaces/categoria';
import { extraerErrores } from '../../../Compartidos/Funciones/extraerErrores';
import { MatTableModule } from '@angular/material/table';
import { I } from '@angular/cdk/keycodes';

@Component({
  selector: 'app-categoria',
  standalone: true,
  imports: [MatButtonModule,RouterLink,MatFormFieldModule,ReactiveFormsModule,MatInputModule,MatTableModule],
  templateUrl: './categoria.component.html',
  styleUrl: './categoria.component.css'
})
export class CategoriaComponent  {
  

  private formBuilder= inject(FormBuilder);
  categoriaService= inject(CategoriaService);
  router = inject(Router);

  listaCategorias!: categoria[];
  nombresColumnas: string[]=["Id","Nombre","Acciones"];

  constructor(){
    this.categoriaService.listar().subscribe({
      next: (data)=>{
        this.listaCategorias= data;

        console.log(this.listaCategorias);
      },
      error: ()=>{}
    });
  }
  

  form= this.formBuilder.group({
    id: [""],
    nombre:["",Validators.required]
  });


  guardarCambios(){
    
    if (!this.form.valid){
      return;
    }

    const categoria = this.form.value as categoria;

    this.categoriaService.crear(categoria).subscribe({
      next: ()=>{
        console.log("Categoria agregada correctamente" )

        //Aca hay que agregar algun msj
      },
      error: (e) =>{
        const errores= extraerErrores(e);
      }
    });
  }

  eliminarCategoria(id:number){

    this.categoriaService.eliminar(id).subscribe({
      next:()=>{
        console.log("Categoria eliminada");
      },
      error: ()=>{}
    })
  }
}
