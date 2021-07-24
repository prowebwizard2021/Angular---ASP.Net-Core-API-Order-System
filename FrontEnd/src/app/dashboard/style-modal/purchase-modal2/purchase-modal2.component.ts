import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'purchase-modal2',
  templateUrl: './purchase-modal2.component.html',
  styleUrls: ['./purchase-modal2.component.css']
})
export class PurchaseModal2Component {
    type: any;
    markdown: any;
    constructor(
        public dialogRef: MatDialogRef<PurchaseModal2Component>,
        @Inject(MAT_DIALOG_DATA) public data: any
    ) {
        console.log("dataPass: ", data)
        if (data.isEdit) {
            this.type = data.data.type
            this.markdown = data.data.markdown
        }
    }
    
    onNoClick(): void {
        this.dialogRef.close();
    }
    
    saveData() {
        this.dialogRef.close({
            type :this.type, 
            markdown: this.markdown
        })
    }
}