namespace InvoiceKu.Purchase {
    export interface VendorContactRow {
        Id?: number;
        VendorId?: number;
        Name?: string;
        Description?: string;
        Street?: string;
        City?: string;
        State?: string;
        ZipCode?: string;
        Phone?: string;
        Email?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        TenantId?: number;
    }

    export namespace VendorContactRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Purchase.VendorContact';
        export const deletePermission = 'Purchase:Vendor';
        export const insertPermission = 'Purchase:Vendor';
        export const readPermission = 'Purchase:Vendor';
        export const updatePermission = 'Purchase:Vendor';

        export declare const enum Fields {
            Id = "Id",
            VendorId = "VendorId",
            Name = "Name",
            Description = "Description",
            Street = "Street",
            City = "City",
            State = "State",
            ZipCode = "ZipCode",
            Phone = "Phone",
            Email = "Email",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            TenantId = "TenantId"
        }
    }
}
