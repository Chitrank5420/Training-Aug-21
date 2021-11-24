/*
There is a retail shop which need to manage the inventory, whenever some purchase is being made product
quantity should be reduced, if quanity is less than 5 reorder request should be raised.
Design an interface and classes for the same.
*/
var RetailShop = /** @class */ (function () {
    function RetailShop() {
    }
    RetailShop.prototype.Purchase = function (pid) {
        var index = this.ProudctId.indexOf(pid);
        if (index != -1) {
            console.log("Purchase Details : \n");
            console.log("Product Name : " + this.ProductName[index]);
            console.log("Product Id : " + this.ProudctId[index]);
            console.log("Product Price : " + this.ProductPrice[index]);
            this.AvailableQuantity[index] = this.AvailableQuantity[index] - 1;
            this.CheckQty(index);
        }
    };
    RetailShop.prototype.CheckQty = function (index) {
        if (this.AvailableQuantity[index] < 5) {
            console.log("Product quantity is less than 5 \n");
        }
        else {
            console.log("Product Quantity Available : " + this.AvailableQuantity[index] + "\n");
        }
    };
    return RetailShop;
}());
var myshop = new RetailShop();
myshop.ProudctId = [1, 2, 3];
myshop.ProductName = ["car", "bike", "Doll"];
myshop.ProductPrice = [100, 60, 30];
myshop.AvailableQuantity = [5, 6, 7];
myshop.Purchase(1);
myshop.Purchase(2);
