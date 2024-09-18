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
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatDialog } from '@angular/material/dialog';
import { ModalEditarComponent } from '../modal-editar/modal-editar.component';
import { SweetAlert2Module } from '@sweetalert2/ngx-sweetalert2';

@Component({
  selector: 'app-categoria',
  standalone: true,
  imports: [MatButtonModule,RouterLink,MatFormFieldModule,ReactiveFormsModule,MatInputModule,MatTableModule,MatProgressSpinnerModule,SweetAlert2Module],
  templateUrl: './categoria.component.html',
  styleUrl: './categoria.component.css'
})
export class CategoriaComponent implements OnInit {
  

  private formBuilder= inject(FormBuilder);
  categoriaService= inject(CategoriaService);
  router = inject(Router);
  dialog = inject(MatDialog);

  listaCategorias!: categoria[];
  nombresColumnas: string[]=["Id","Nombre","Acciones"];
  formVisible: boolean=false;

  constructor(){}
  
  form= this.formBuilder.group({
    id: [""],
    nombre:["",Validators.required]
  });
  
  ngOnInit(): void {
    this.listarCategorias();
  }

  openDialog(categoria:categoria): void {
    console.log(categoria);
    const dialogRef = this.dialog.open(ModalEditarComponent, {
      data: {id: categoria.id, nombre: categoria.nombre}
    });

    dialogRef.afterClosed().subscribe(result => {
        if(result.nombre == categoria.nombre || result == undefined ){
          return;
        }

        categoria.nombre= result.nombre;
        this.categoriaService.modificar(categoria.id!,categoria).subscribe({
          next:() =>{
            console.log("Modificada correcamente");

            this.listarCategorias();
          },
          error:(e)=>{console.log(e)}
        });
      }
    );
  }
  cambiarVisibilidad(){
    this.formVisible=!this.formVisible;
  }

  listarCategorias(){
    this.categoriaService.listar().subscribe({
      next: (data)=>{
        this.listaCategorias= data;

        console.log(this.listaCategorias);
      },
      error: ()=>{}
    });
  }


  guardarCambios(){
    
    if (!this.form.valid){
      return;
    }

    const categoria = this.form.value as categoria;

    this.categoriaService.crear(categoria).subscribe({
      next: ()=>{
        console.log("Categoria agregada correctamente" )

        this.listarCategorias();
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
        this.listarCategorias();
      },
      error: ()=>{}
    })
  }
}
