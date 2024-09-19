import { Component,inject,viewChild } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, RequiredValidator, Validators } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import{Router, RouterLink} from '@angular/router';
import { MarcaService } from '../../../Services/marca.service';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { marca } from '../../../Interfaces/marca';
import { MatAccordion, MatExpansionModule } from '@angular/material/expansion';
import { UtilidadService } from '../../../Services/utilidad.service';
import { ModalEditarMarcaComponent } from '../modal-editar-marca/modal-editar-marca.component';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatTableModule } from '@angular/material/table';
import { SweetAlert2Module } from '@sweetalert2/ngx-sweetalert2';
import { MatPaginatorModule } from '@angular/material/paginator';

@Component({
  selector: 'app-marca',
  standalone: true,
  imports: [MatButtonModule,RouterLink,MatFormFieldModule,ReactiveFormsModule,MatInputModule,MatDialogModule,MatAccordion,MatExpansionModule,MatExpansionModule,MatProgressSpinnerModule,MatTableModule
    ,SweetAlert2Module,MatPaginatorModule
  ],
  templateUrl: './marca.component.html',
  styleUrl: './marca.component.css'
})
export class MarcaComponent {

  private formBuilder= inject(FormBuilder);
  marcaService= inject(MarcaService);
  router = inject(Router);
  dialog = inject(MatDialog);

  listaMarcas!: marca[];
  nombresColumnas: string[]=["Id","Nombre","Acciones"];

  cantidadRegistros: number=0;

  accordion = viewChild.required(MatAccordion);

  utilidades= inject(UtilidadService);
  
  constructor(){}
  
  form= this.formBuilder.group({
    id: [""],
    nombre:["",Validators.required]
  });
  
  ngOnInit(): void {
    this.listarMarcas();
  }

  openDialog(marca:marca): void {

    const dialogRef = this.dialog.open(ModalEditarMarcaComponent, {
      data: {id: marca.id, nombre: marca.nombre}
    });

    dialogRef.afterClosed().subscribe(result => {
        if(result.nombre == marca.nombre || result == undefined ){
          return;
        }

        marca.nombre= result.nombre;
        this.modificar(marca);
    }
    );
  }

  modificar(marca:marca){
    this.marcaService.modificar(marca.id!,marca).subscribe({
      next:() =>{
        this.utilidades.mostrarAlerta("Marca modificada exitosamente","Exito");
        this.listarMarcas();
      },
      error:(e)=>{
        console.log(e)
        this.utilidades.mostrarAlerta("No se pudo modificar la marca","Error");
      }
    });
  }

  listarMarcas(){
    this.marcaService.listar().subscribe({
      next: (data)=>{
        this.listaMarcas= data;
        this.cantidadRegistros= this.listaMarcas.length;
      },
      error: ()=>{}
    });
  }

  guardarCambios(){
    if (!this.form.valid){
      return;
    }

    const marca = this.form.value as marca;

    this.marcaService.crear(marca).subscribe({
      next: ()=>{
        this.utilidades.mostrarAlerta("Marca agregada exitosamente","Exito");
        this.listarMarcas();
      },
      error: (e) =>{
       console.log(e);
        this.utilidades.mostrarAlerta("No se pudo agregar la marca","Error");
      }
    });
  }

  eliminarCategoria(id:number){

    this.marcaService.eliminar(id).subscribe({
      next:()=>{
        console.log("Marca eliminada");
        this.listarMarcas();
      },
      error: ()=>{}
    })
  }
}
