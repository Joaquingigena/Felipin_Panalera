import { Component,inject,model } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogTitle, MatDialogContent, MatDialogActions, MatDialogClose,MAT_DIALOG_DATA,MatDialogRef } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { marca } from '../../../Interfaces/marca';

@Component({
  selector: 'app-modal-editar-marca',
  standalone: true,
  imports: [   MatFormFieldModule,
    MatInputModule,
    FormsModule,
    MatButtonModule,
    MatDialogTitle,
    MatDialogContent,
    MatDialogActions,
    MatDialogClose],
  templateUrl: './modal-editar-marca.component.html',
  styleUrl: './modal-editar-marca.component.css'
})
export class ModalEditarMarcaComponent {

  dialogRef= inject(MatDialogRef<ModalEditarMarcaComponent>);
  data= inject<marca>(MAT_DIALOG_DATA);
  marca = model(this.data);

  constructor(){}
  
  cancelar(){
    this.dialogRef.close();
  }
}
