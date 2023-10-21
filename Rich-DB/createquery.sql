CREATE TABLE tags (
    id SERIAL PRIMARY KEY,
    tag_name VARCHAR(255),
    icon TEXT,
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE categories (
    id UUID PRIMARY KEY,
    parent_id UUID REFERENCES categories(id),
    category_name VARCHAR(255),
    category_description TEXT,
    icon TEXT,
    image_path TEXT,
    active BOOLEAN,
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE products (
    id UUID PRIMARY KEY,
    product_name VARCHAR(255),
    SKU VARCHAR(255),
    regular_price NUMERIC,
    discount_price NUMERIC,
    quantity INTEGER,
    short_description TEXT,
    product_description TEXT,
    product_weight NUMERIC,
    product_note VARCHAR(255),
    published BOOLEAN,
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE variants (
    id UUID PRIMARY KEY,
    product_id UUID REFERENCES products(id)
);

CREATE TABLE variant_values (
    id UUID PRIMARY KEY,
    variant_id UUID REFERENCES variants(id),
    price NUMERIC,
    quantity INTEGER
);

CREATE TABLE product_tags (
    tag_id INTEGER REFERENCES tags(id),
    product_id UUID REFERENCES products(id),
    PRIMARY KEY(tag_id, product_id)
);

CREATE TABLE product_categories (
    category_id UUID REFERENCES categories(id),
    product_id UUID REFERENCES products(id),
    PRIMARY KEY(category_id, product_id)
);

CREATE TABLE staff_accounts (
    id UUID PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    phone_number VARCHAR(100),
    email VARCHAR(255),
    password_hash TEXT,
    active BOOLEAN,
    profile_img TEXT,
    registered_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE roles (
    id SERIAL PRIMARY KEY,
    role_name VARCHAR(255),
    privileges TEXT,
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE staff_roles (
    staff_id UUID REFERENCES staff_accounts(id),
    role_id INTEGER REFERENCES roles(id),
    PRIMARY KEY(staff_id, role_id)
);

CREATE TABLE notifications (
    id UUID PRIMARY KEY,
    account_name UUID REFERENCES staff_accounts(id),
    title VARCHAR(100),
    content TEXT,
    seen BOOLEAN,
    created_at TIMESTAMP,
    received_time TIMESTAMP,
    notification_expiry_date DATE
);

CREATE TABLE slideshows (
    id UUID PRIMARY KEY,
    destination_url TEXT,
    image_url TEXT,
    clicks SMALLINT,
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE attributes (
    id UUID PRIMARY KEY,
    attribute_name VARCHAR(255),
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE attribute_values (
    id UUID PRIMARY KEY,
    attribute_id UUID REFERENCES attributes(id),
    attribute_value VARCHAR(255),
    color VARCHAR(50)
);

CREATE TABLE variant_attribute_values (
    variant_id UUID REFERENCES variants(id),
    attribute_value_id UUID REFERENCES attribute_values(id),
    PRIMARY KEY(variant_id, attribute_value_id)
);

CREATE TABLE galleries (
    id UUID PRIMARY KEY,
    product_id UUID REFERENCES products(id),
    image_path TEXT,
    thumbnail BOOLEAN,
    display_order SMALLINT,
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE sells (
    id UUID PRIMARY KEY,
    product_id UUID REFERENCES products(id),
    price FLOAT,
    quantity SMALLINT
);

CREATE TABLE coupons (
    id UUID PRIMARY KEY,
    code VARCHAR(255),
    coupon_description TEXT,
    discount_value NUMERIC,
    discount_type VARCHAR(50),
    times_used INTEGER,
    max_usage INTEGER,
    coupon_start_date TIMESTAMP,
    coupon_end_date TIMESTAMP,
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    created_by UUID,
    updated_by UUID
);

CREATE TABLE product_coupons (
   coupon_id UUID REFERENCES coupons(id),
   product_id UUID REFERENCES products(id),
   PRIMARY KEY(coupon_id, product_id)
);

CREATE TABLE customers (
   id UUID PRIMARY KEY,
   first_name VARCHAR(100),
   last_name VARCHAR(100),
   phone_number VARCHAR(255),
   email TEXT,
   password_hash TEXT,
   active BOOLEAN,
   registered_at TIMESTAMP,
   created_at TIMESTAMP
);

CREATE TABLE customer_addresses (
   id UUID PRIMARY KEY,
   customer_id UUID REFERENCES customers(id),
   address_line1 TEXT,
   address_line2 TEXT,
   postal_code VARCHAR(255),
   country VARCHAR(255),
   city VARCHAR(255),
   phone_number VARCHAR(255)
);

CREATE TABLE order_statuses (
   id SERIAL PRIMARY KEY,
   status_name VARCHAR(255),
   color VARCHAR(50),
   privacy VARCHAR(50),
   created_at TIMESTAMP,
   updated_at TIMESTAMP,
   created_by UUID,
   updated_by UUID
);

CREATE TABLE orders (
   id UUID PRIMARY KEY,
   coupon_id UUID REFERENCES coupons(id),
   customer_id UUID REFERENCES customers(id),
   order_status_id INTEGER REFERENCES order_statuses(id),
   order_approved_at TIMESTAMP,
   order_delivered_at TIMESTAMP,
   order_delivered_carrier_date TIMESTAMP,
   created_at TIMESTAMP
);

CREATE TABLE cards (
   id UUID PRIMARY KEY,
   customer_id UUID REFERENCES customers(id)
);

CREATE TABLE card_items (
   id UUID NOT NULL,
   card_id UUID REFERENCES cards(id),
   product_id UUID REFERENCES products(id),
   quantity SMALLINT,
   PRIMARY KEY(card_id, product_id)
);

CREATE TABLE shippings (
   id SERIAL PRIMARY KEY ,
   name TEXT ,
   active BOOLEAN ,
   icon_path TEXT ,
   created_at TIMESTAMP ,
   updated_at TIMESTAMP ,
   created_by UUID ,
   updated_by UUID 
);

CREATE TABLE product_shippings (
   product_id UUID REFERENCES products(id) ,
   shipping_id INTEGER REFERENCES shippings(id) ,
   ship_charge NUMERIC ,
   free BOOLEAN ,
   estimated NUMERIC ,
   PRIMARY KEY(product_id, shipping_id)
);

CREATE TABLE order_items (
   id UUID NOT NULL ,
   product_id UUID REFERENCES products(id) ,
   order_id UUID REFERENCES orders(id) ,
   price NUMERIC ,
   quantity INTEGER ,
   shipping_id INTEGER REFERENCES shippings(id) ,
   PRIMARY KEY(product_id, order_id)
);

CREATE TABLE product_attributes (
   product_id UUID REFERENCES products(id) ,
   attribute_id UUID REFERENCES attributes(id) ,
   PRIMARY KEY(product_id, attribute_id)
);
