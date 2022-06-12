
namespace InvoiceKu.Sales {

    @Serenity.Decorators.registerClass()
    export class CustumerContactDialog extends Serenity.EntityDialog<CustumerContactRow, any> {
        protected getFormKey() { return CustumerContactForm.formKey; }
        protected getIdProperty() { return CustumerContactRow.idProperty; }
        protected getLocalTextPrefix() { return CustumerContactRow.localTextPrefix; }
        protected getNameProperty() { return CustumerContactRow.nameProperty; }
        protected getService() { return CustumerContactService.baseUrl; }
        protected getDeletePermission() { return CustumerContactRow.deletePermission; }
        protected getInsertPermission() { return CustumerContactRow.insertPermission; }
        protected getUpdatePermission() { return CustumerContactRow.updatePermission; }

        protected form = new CustumerContactForm(this.idPrefix);

    }
}