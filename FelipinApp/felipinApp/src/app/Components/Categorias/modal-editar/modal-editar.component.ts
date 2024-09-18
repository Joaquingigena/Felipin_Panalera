import { Dialog } from '@angular/cdk/dialog';
import { Component, inject, model, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MAT_DIALOG_DATA, MatDialogActions, MatDialogClose, MatDialogContent, MatDialogRef, MatDialogTitle } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { categoria } from '../../../Interfaces/categoria';

@Component({
  selector: 'app-modal-editar',
  standalone: true,
  imports: [   MatFormFieldModule,
    MatInputModule,
    FormsModule,
    MatButtonModule,
    MatDialogTitle,
    MatDialogContent,
    MatDialogActions,
    MatDialogClose],
  templateUrl: './modal-editar.component.html',
  styleUrl: './modal-editar.component.css'
})
export class ModalEditarComponent implements OnInit {

  dialogRef= inject(MatDialogRef<ModalEditarComponent>);
  data= inject<categoria>(MAT_DIALOG_DATA);
  categoria = model(this.data);

  constructor(){
    
  }
  ngOnInit(): void {
    console.log(this.data.nombre);
    console.log(this.data);
    console.log(this.categoria)
  }
  
  guardarCambios(){

  }

  cancelar(){
    this.dialogRef.close();
  }
}


// readonly dialogRef = inject(MatDialogRef<DialogOverviewExampleDialog>);
//   readonly data = inject<categoria>(MAT_DIALOG_DATA);
//   readonly animal = model(this.data.animal);

//   onNoClick(): void {
//     this.dialogRef.close();
//   }