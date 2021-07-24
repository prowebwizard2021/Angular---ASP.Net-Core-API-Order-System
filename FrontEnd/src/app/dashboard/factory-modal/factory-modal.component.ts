import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
    selector: 'factory-modal',
    templateUrl: './factory-modal.component.html',
    styleUrls: ['./factory-modal.component.css']
  })
  export class FactoryModalComponent{
    title: any;
    constructor(
        public dialogRef: MatDialogRef<FactoryModalComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any
    ){
      console.log("dataPass: ", data)
    }
  
    saveBtn(): void {
      this.dialogRef.close({
        title: this.title
      });
    }
    cancelBtn() {
      this.dialogRef.close()
    }
  
  }