import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatDialog } from '@angular/material/dialog';
import { PurchaseModal1Component } from './purchase-modal1/purchase-modal1.component';
import { PurchaseModal2Component } from './purchase-modal2/purchase-modal2.component';

@Component({
    selector: 'style-modal',
    templateUrl: './style-modal.component.html',
    styleUrls: ['./style-modal.component.css']
  })
  export class StyleModalComponent{
    foods: any = []
    title: string;
    quantityPlaced: number;
    quantityOrdered: number;
    purchasePrice1: number;
    purchasePrice2: number;
    purchasePrice3: number;
    exchangeRatePurchasePrice: number;
    rateOfDutyPuchasePrice: number;
    vKGP: number;
    vKGPNachLB: number;

    markupTable: any[] = [
      {type:"Type A", markup: "0.24" },
      {type:"Type A", markup: "0.24" },
      {type:"Type A", markup: "0.24" },
    ];
  
    markdownTable: any[] = [
      {type:"Type A", markdown: "0.24"},
      {type:"Type A", markdown: "0.24"},
      {type:"Type A", markdown: "0.24"},
    ];

    constructor(
        public dialogRef: MatDialogRef<StyleModalComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
        public dialog: MatDialog
    ){
      console.log("dataPass: ", data)
      if (data.isEdit) {
        this.title = data.data.title;
        this.quantityPlaced = data.data.quantityPlaced;
        this.quantityOrdered = data.data.quantityOrdered;
        this.purchasePrice1 = data.data.purchasePrice1;
        this.purchasePrice2 = data.data.purchasePrice2;
        this.purchasePrice3 = data.data.purchasePrice3;
        this.exchangeRatePurchasePrice = data.data.exchangeRatePurchasePrice;
        this.rateOfDutyPuchasePrice = data.data.rateOfDutyPuchasePrice;
        this.vKGP = data.data.vKGP;
        this.vKGPNachLB = data.data.vKGPNachLB;
      }
    }
  
    saveBtn(): void {
      this.dialogRef.close({
        title: this.title,
        quantityPlaced: this.quantityPlaced,
        quantityOrdered: this.quantityOrdered,
        purchasePrice1: this.purchasePrice1,
        purchasePrice2: this.purchasePrice2,
        purchasePrice3: this.purchasePrice3,
        exchangeRatePurchasePrice: this.exchangeRatePurchasePrice,
        rateOfDutyPuchasePrice: this.rateOfDutyPuchasePrice,
        vKGP: this.vKGP,
        vKGPNachLB: this.vKGPNachLB
      });
    }
    cancelBtn() {
      this.dialogRef.close()
    }
    openPurchaseModal1(isEdit, index) : void{
      let data = null
      if (isEdit) {
        data = this.markupTable[index]
      }
      const dialogRef = this.dialog.open(PurchaseModal1Component, {
        width: '550px',
        data: {
          isEdit,
          data
        }
      });
  
      dialogRef.afterClosed().subscribe(res => {
        console.log(res);
        if (res) {
          if (isEdit) {
            this.markupTable[index] = res
          } else {
            this.markupTable.push(res);
          }
        }
      });
    }
    openPurchaseModal2(isEdit, index) : void{
      let data = null
      if (isEdit) {
        data = this.markdownTable[index]
      }
      const dialogRef = this.dialog.open(PurchaseModal2Component, {
        width: '550px',
        data: {
          isEdit,
          data
        }
      });
  
      dialogRef.afterClosed().subscribe(res => {
          console.log(res);
          if (res) {
            if (isEdit) {
              this.markdownTable[index] = res
            } else {
              this.markdownTable.push(res);
            }
          }
      });
    }
  
    removeMarkup(index) {
      this.markupTable.splice(index, 1)
    }
  
    removeMarkdown(index) {
      this.markdownTable.splice(index, 1)
    }
  
  }