
namespace InvoiceKu.Sales {

    @Serenity.Decorators.registerClass()
    export class CustumerContactGrid extends Serenity.EntityGrid<CustumerContactRow, any> {
        protected getColumnsKey() { return CustumerContactColumns.columnsKey; }
        protected getDialogType() { return CustumerContactDialog; }
        protected getIdProperty() { return CustumerContactRow.idProperty; }
        protected getInsertPermission() { return CustumerContactRow.insertPermission; }
        protected getLocalTextPrefix() { return CustumerContactRow.localTextPrefix; }
        protected getService() { return CustumerContactService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}