﻿namespace InvoiceKu.Purchase {
    export interface PurchaseOrderDetailRow {
        Id?: number;
        PurchaseOrderId?: number;
        ProductId?: number;
        Price?: number;
        Qty?: number;
        SubTotal?: number;
        Discount?: number;
        BeforeTax?: number;
        TaxPercentage?: number;
        TaxAmount?: number;
        Total?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        TenantId?: number;
    }

    export namespace PurchaseOrderDetailRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'Purchase.PurchaseOrderDetail';
        export const deletePermission = 'Purchase:PurchaseOrder';
        export const insertPermission = 'Purchase:PurchaseOrder';
        export const readPermission = 'Purchase:PurchaseOrder';
        export const updatePermission = 'Purchase:PurchaseOrder';

        export declare const enum Fields {
            Id = "Id",
            PurchaseOrderId = "PurchaseOrderId",
            ProductId = "ProductId",
            Price = "Price",
            Qty = "Qty",
            SubTotal = "SubTotal",
            Discount = "Discount",
            BeforeTax = "BeforeTax",
            TaxPercentage = "TaxPercentage",
            TaxAmount = "TaxAmount",
            Total = "Total",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            TenantId = "TenantId"
        }
    }
}