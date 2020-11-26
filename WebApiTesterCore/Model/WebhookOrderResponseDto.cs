namespace WebApiTesterCore.Model
{
    public class WebhookOrderResponseDto
    {
        public long? id { get; set; }
        public string email { get; set; }
        public string closed_at { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public int? number { get; set; }
        public object note { get; set; }
        public string token { get; set; }
        public string gateway { get; set; }
        public bool test { get; set; }
        public string total_price { get; set; }
        public string subtotal_price { get; set; }
        public int? total_weight { get; set; }
        public string total_tax { get; set; }
        public bool taxes_included { get; set; }
        public string currency { get; set; }
        public string financial_status { get; set; }
        public bool confirmed { get; set; }
        public string total_discounts { get; set; }
        public string total_line_items_price { get; set; }
        public object cart_token { get; set; }
        public bool buyer_accepts_marketing { get; set; }
        public string name { get; set; }
        public object referring_site { get; set; }
        public object landing_site { get; set; }
        public object cancelled_at { get; set; }
        public object cancel_reason { get; set; }
        public string total_price_usd { get; set; }
        public object checkout_token { get; set; }
        public object reference { get; set; }
        public object user_id { get; set; }
        public object location_id { get; set; }
        public object source_identifier { get; set; }
        public object source_url { get; set; }
        public string processed_at { get; set; }
        public object device_id { get; set; }
        public object phone { get; set; }
        public object customer_locale { get; set; }
        public int? app_id { get; set; }
        public object browser_ip { get; set; }
        public object landing_site_ref { get; set; }
        public int? order_number { get; set; }
        public Discount_Applications[] discount_applications { get; set; }
        public object[] discount_codes { get; set; }
        public object[] note_attributes { get; set; }
        public object[] payment_gateway_names { get; set; }
        public string processing_method { get; set; }
        public object checkout_id { get; set; }
        public string source_name { get; set; }
        public object fulfillment_status { get; set; }
        public object[] tax_lines { get; set; }
        public string tags { get; set; }
        public object contact_email { get; set; }
        public string order_status_url { get; set; }
        public string presentment_currency { get; set; }
        public Total_Line_Items_Price_Set total_line_items_price_set { get; set; }
        public Total_Discounts_Set total_discounts_set { get; set; }
        public Total_Shipping_Price_Set total_shipping_price_set { get; set; }
        public Subtotal_Price_Set subtotal_price_set { get; set; }
        public Total_Price_Set total_price_set { get; set; }
        public Total_Tax_Set total_tax_set { get; set; }
        public Line_Items[] line_items { get; set; }
        public object[] fulfillments { get; set; }
        public object[] refunds { get; set; }
        public string total_tip_received { get; set; }
        public object original_total_duties_set { get; set; }
        public object current_total_duties_set { get; set; }
        public string admin_graphql_api_id { get; set; }
        public Shipping_Lines[] shipping_lines { get; set; }
        public Billing_Address billing_address { get; set; }
        public Shipping_Address shipping_address { get; set; }
        public Customer customer { get; set; }
    }

    public class Discount_Applications
    {
        public string type { get; set; }
        public string value { get; set; }
        public string value_type { get; set; }
        public string allocation_method { get; set; }
        public string target_selection { get; set; }
        public string target_type { get; set; }
        public string description { get; set; }
        public string title { get; set; }
    }

    public class Billing_Address
    {
        public string first_name { get; set; }
        public string address1 { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string last_name { get; set; }
        public object address2 { get; set; }
        public string company { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
        public string name { get; set; }
        public string country_code { get; set; }
        public string province_code { get; set; }
    }

    public class Shipping_Address
    {
        public string first_name { get; set; }
        public string address1 { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string last_name { get; set; }
        public object address2 { get; set; }
        public string company { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
        public string name { get; set; }
        public string country_code { get; set; }
        public string province_code { get; set; }
    }

    public class Customer
    {
        public long? id { get; set; }
        public string email { get; set; }
        public bool accepts_marketing { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int? orders_count { get; set; }
        public string state { get; set; }
        public string total_spent { get; set; }
        public object last_order_id { get; set; }
        public object note { get; set; }
        public bool verified_email { get; set; }
        public object multipass_identifier { get; set; }
        public bool tax_exempt { get; set; }
        public object phone { get; set; }
        public string tags { get; set; }
        public object last_order_name { get; set; }
        public string currency { get; set; }
        public object accepts_marketing_updated_at { get; set; }
        public object marketing_opt_in_level { get; set; }
        public string admin_graphql_api_id { get; set; }
        public Default_Address default_address { get; set; }
    }

    public class Default_Address
    {
        public long? id { get; set; }
        public long? customer_id { get; set; }
        public object first_name { get; set; }
        public object last_name { get; set; }
        public object company { get; set; }
        public string address1 { get; set; }
        public object address2 { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string name { get; set; }
        public string province_code { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public bool _default { get; set; }
    }

    public class Shipping_Lines
    {
        public long? id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public object code { get; set; }
        public string source { get; set; }
        public object phone { get; set; }
        public object requested_fulfillment_service_id { get; set; }
        public object delivery_category { get; set; }
        public object carrier_identifier { get; set; }
        public string discounted_price { get; set; }
        public Price_Set price_set { get; set; }
        public Discounted_Price_Set discounted_price_set { get; set; }
        public object[] discount_allocations { get; set; }
        public object[] tax_lines { get; set; }
    }

    public class Discounted_Price_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }

    public class Total_Line_Items_Price_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }

    public class Shop_Money
    {
        public string amount { get; set; }
        public string currency_code { get; set; }
    }

    public class Presentment_Money
    {
        public string amount { get; set; }
        public string currency_code { get; set; }
    }

    public class Total_Discounts_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }

    public class Total_Shipping_Price_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }

    public class Subtotal_Price_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }

    public class Total_Price_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }

    public class Total_Tax_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }

    public class Line_Items
    {
        public long? id { get; set; }
        public long? variant_id { get; set; }
        public string title { get; set; }
        public int? quantity { get; set; }
        public string sku { get; set; }
        public object variant_title { get; set; }
        public string vendor { get; set; }
        public string fulfillment_service { get; set; }
        public long? product_id { get; set; }
        public bool requires_shipping { get; set; }
        public bool taxable { get; set; }
        public bool gift_card { get; set; }
        public string name { get; set; }
        public object variant_inventory_management { get; set; }
        public object[] properties { get; set; }
        public bool product_exists { get; set; }
        public int fulfillable_quantity { get; set; }
        public int grams { get; set; }
        public string price { get; set; }
        public string total_discount { get; set; }
        public object fulfillment_status { get; set; }
        public Price_Set price_set { get; set; }
        public Total_Discount_Set total_discount_set { get; set; }
        public object[] discount_allocations { get; set; }
        public object[] duties { get; set; }
        public string admin_graphql_api_id { get; set; }
        public object[] tax_lines { get; set; }
    }

    public class Price_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }

    public class Total_Discount_Set
    {
        public Shop_Money shop_money { get; set; }
        public Presentment_Money presentment_money { get; set; }
    }
}