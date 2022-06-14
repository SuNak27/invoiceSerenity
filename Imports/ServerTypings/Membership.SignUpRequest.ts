namespace InvoiceKu.Membership {
    export interface SignUpRequest extends Serenity.ServiceRequest {
        CompanyName?: string;
        DisplayName?: string;
        Email?: string;
        Password?: string;
    }
}
