import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'purchase-modal1',
  templateUrl: './purchase-modal1.component.html',
  styleUrls: ['./purchase-modal1.component.css']
})
export class PurchaseModal1Component {
    type: any;
    markup: any;
    constructor(
        public dialogRef: MatDialogRef<PurchaseModal1Component>,
        @Inject(MAT_DIALOG_DATA) public data: any
    ) {
        console.log("dataPass: ", data)
        if (data.isEdit) {
            this.type = data.data.type
            this.markup = data.data.markup
        }
    }
    
    onNoClick(): void {
        this.dialogRef.close();
    }
    saveData() {
        this.dialogRef.close({
            type: this.type, 
            markup: this.markup, 
        })
    }
}
