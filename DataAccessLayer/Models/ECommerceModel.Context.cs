﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sdirecttestdbEntities1 : DbContext
    {
        public sdirecttestdbEntities1()
            : base("name=sdirecttestdbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAddress_Sk> tblAddress_Sk { get; set; }
        public virtual DbSet<tblBank_Sk> tblBank_Sk { get; set; }
        public virtual DbSet<tblBusinessType_Sk> tblBusinessType_Sk { get; set; }
        public virtual DbSet<tblBuyers_Sk> tblBuyers_Sk { get; set; }
        public virtual DbSet<tblCity_Sk> tblCity_Sk { get; set; }
        public virtual DbSet<tblCountry_Sk> tblCountry_Sk { get; set; }
        public virtual DbSet<tblInventory_Sk> tblInventory_Sk { get; set; }
        public virtual DbSet<tblItems_Sk> tblItems_Sk { get; set; }
        public virtual DbSet<tblOrders_Sk> tblOrders_Sk { get; set; }
        public virtual DbSet<tblOrderStatus_Sk> tblOrderStatus_Sk { get; set; }
        public virtual DbSet<tblPaymentMethod_Sk> tblPaymentMethod_Sk { get; set; }
        public virtual DbSet<tblProducts_Sk> tblProducts_Sk { get; set; }
        public virtual DbSet<tblProductsCategory_Sk> tblProductsCategory_Sk { get; set; }
        public virtual DbSet<tblRole_Sk> tblRole_Sk { get; set; }
        public virtual DbSet<tblSellers_Sk> tblSellers_Sk { get; set; }
        public virtual DbSet<tblSellerStatus_Sk> tblSellerStatus_Sk { get; set; }
        public virtual DbSet<tblShippingMethod_Sk> tblShippingMethod_Sk { get; set; }
        public virtual DbSet<tblState_Sk> tblState_Sk { get; set; }
        public virtual DbSet<tblUser_Sk> tblUser_Sk { get; set; }
        public virtual DbSet<tblBankNameUser_Sk> tblBankNameUser_Sk { get; set; }
        public virtual DbSet<tblOtp_Sk> tblOtp_Sk { get; set; }
    
        public virtual int spAddOtp_Sk(string email, Nullable<int> oTP)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var oTPParameter = oTP.HasValue ?
                new ObjectParameter("OTP", oTP) :
                new ObjectParameter("OTP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddOtp_Sk", emailParameter, oTPParameter);
        }
    
        public virtual int spAddProduct_Sk(Nullable<int> productCategoryId, string productName, string description, string brand, byte[] image, string sellerName, string updaterName, Nullable<int> pricePerUnit, Nullable<int> productCount, Nullable<int> sellerId)
        {
            var productCategoryIdParameter = productCategoryId.HasValue ?
                new ObjectParameter("ProductCategoryId", productCategoryId) :
                new ObjectParameter("ProductCategoryId", typeof(int));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var brandParameter = brand != null ?
                new ObjectParameter("Brand", brand) :
                new ObjectParameter("Brand", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(byte[]));
    
            var sellerNameParameter = sellerName != null ?
                new ObjectParameter("SellerName", sellerName) :
                new ObjectParameter("SellerName", typeof(string));
    
            var updaterNameParameter = updaterName != null ?
                new ObjectParameter("UpdaterName", updaterName) :
                new ObjectParameter("UpdaterName", typeof(string));
    
            var pricePerUnitParameter = pricePerUnit.HasValue ?
                new ObjectParameter("PricePerUnit", pricePerUnit) :
                new ObjectParameter("PricePerUnit", typeof(int));
    
            var productCountParameter = productCount.HasValue ?
                new ObjectParameter("ProductCount", productCount) :
                new ObjectParameter("ProductCount", typeof(int));
    
            var sellerIdParameter = sellerId.HasValue ?
                new ObjectParameter("SellerId", sellerId) :
                new ObjectParameter("SellerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddProduct_Sk", productCategoryIdParameter, productNameParameter, descriptionParameter, brandParameter, imageParameter, sellerNameParameter, updaterNameParameter, pricePerUnitParameter, productCountParameter, sellerIdParameter);
        }
    
        public virtual int spChangeOrderStatus_Sk(Nullable<int> orderId, string orderStatus, Nullable<int> userId)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var orderStatusParameter = orderStatus != null ?
                new ObjectParameter("OrderStatus", orderStatus) :
                new ObjectParameter("OrderStatus", typeof(string));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spChangeOrderStatus_Sk", orderIdParameter, orderStatusParameter, userIdParameter);
        }
    
        public virtual int spChangeSellerStatus_Sk(Nullable<int> sELLERID, Nullable<bool> fLAG)
        {
            var sELLERIDParameter = sELLERID.HasValue ?
                new ObjectParameter("SELLERID", sELLERID) :
                new ObjectParameter("SELLERID", typeof(int));
    
            var fLAGParameter = fLAG.HasValue ?
                new ObjectParameter("FLAG", fLAG) :
                new ObjectParameter("FLAG", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spChangeSellerStatus_Sk", sELLERIDParameter, fLAGParameter);
        }
    
        public virtual int spCheckSellerStatus_Sk(Nullable<int> sellerId)
        {
            var sellerIdParameter = sellerId.HasValue ?
                new ObjectParameter("SellerId", sellerId) :
                new ObjectParameter("SellerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCheckSellerStatus_Sk", sellerIdParameter);
        }
    
        public virtual int spCreateOrder_Sk(Nullable<int> uSERID, Nullable<int> productCount, Nullable<int> pRODUCTID)
        {
            var uSERIDParameter = uSERID.HasValue ?
                new ObjectParameter("USERID", uSERID) :
                new ObjectParameter("USERID", typeof(int));
    
            var productCountParameter = productCount.HasValue ?
                new ObjectParameter("ProductCount", productCount) :
                new ObjectParameter("ProductCount", typeof(int));
    
            var pRODUCTIDParameter = pRODUCTID.HasValue ?
                new ObjectParameter("PRODUCTID", pRODUCTID) :
                new ObjectParameter("PRODUCTID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCreateOrder_Sk", uSERIDParameter, productCountParameter, pRODUCTIDParameter);
        }
    
        public virtual int spDeleteOtp_Sk(Nullable<int> otpId)
        {
            var otpIdParameter = otpId.HasValue ?
                new ObjectParameter("OtpId", otpId) :
                new ObjectParameter("OtpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteOtp_Sk", otpIdParameter);
        }
    
        public virtual int spExecutePayment_Sk(Nullable<int> orderId, string email, string password, string accountNumber, Nullable<int> bankId)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var accountNumberParameter = accountNumber != null ?
                new ObjectParameter("AccountNumber", accountNumber) :
                new ObjectParameter("AccountNumber", typeof(string));
    
            var bankIdParameter = bankId.HasValue ?
                new ObjectParameter("BankId", bankId) :
                new ObjectParameter("BankId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spExecutePayment_Sk", orderIdParameter, emailParameter, passwordParameter, accountNumberParameter, bankIdParameter);
        }
    
        public virtual int spFinalizeOrder_Sk(Nullable<int> oRDERID)
        {
            var oRDERIDParameter = oRDERID.HasValue ?
                new ObjectParameter("ORDERID", oRDERID) :
                new ObjectParameter("ORDERID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spFinalizeOrder_Sk", oRDERIDParameter);
        }
    
        public virtual ObjectResult<spGetAllUsers_Sk_Result> spGetAllUsers_Sk()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllUsers_Sk_Result>("spGetAllUsers_Sk");
        }
    
        public virtual ObjectResult<spGetItemCountAndInventoryId_Sk_Result> spGetItemCountAndInventoryId_Sk(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetItemCountAndInventoryId_Sk_Result>("spGetItemCountAndInventoryId_Sk", userIdParameter);
        }
    
        public virtual ObjectResult<spGetMyCart_Sk_Result> spGetMyCart_Sk(Nullable<int> inventoryId)
        {
            var inventoryIdParameter = inventoryId.HasValue ?
                new ObjectParameter("InventoryId", inventoryId) :
                new ObjectParameter("InventoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetMyCart_Sk_Result>("spGetMyCart_Sk", inventoryIdParameter);
        }
    
        public virtual ObjectResult<spGetProducts_Sk_Result> spGetProducts_Sk(string productName)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetProducts_Sk_Result>("spGetProducts_Sk", productNameParameter);
        }
    
        public virtual ObjectResult<string> spGetSellerFullName_Sk(Nullable<int> sellerId)
        {
            var sellerIdParameter = sellerId.HasValue ?
                new ObjectParameter("SellerId", sellerId) :
                new ObjectParameter("SellerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spGetSellerFullName_Sk", sellerIdParameter);
        }
    
        public virtual ObjectResult<spGetUserDetails_Sk_Result> spGetUserDetails_Sk(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserDetails_Sk_Result>("spGetUserDetails_Sk", userIdParameter);
        }
    
        public virtual int spRegisterUser_Sk(string firstName, string middleName, string lastName, string email, string password, byte[] image, string mobile, string cityName1, Nullable<long> pincode1, string type1, string address1, string type2, string cityName2, Nullable<long> pincode2, string address2, Nullable<bool> isSeller, string businessType, string bankName, string accountNumber)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("MiddleName", middleName) :
                new ObjectParameter("MiddleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(byte[]));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var cityName1Parameter = cityName1 != null ?
                new ObjectParameter("CityName1", cityName1) :
                new ObjectParameter("CityName1", typeof(string));
    
            var pincode1Parameter = pincode1.HasValue ?
                new ObjectParameter("Pincode1", pincode1) :
                new ObjectParameter("Pincode1", typeof(long));
    
            var type1Parameter = type1 != null ?
                new ObjectParameter("Type1", type1) :
                new ObjectParameter("Type1", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var type2Parameter = type2 != null ?
                new ObjectParameter("Type2", type2) :
                new ObjectParameter("Type2", typeof(string));
    
            var cityName2Parameter = cityName2 != null ?
                new ObjectParameter("CityName2", cityName2) :
                new ObjectParameter("CityName2", typeof(string));
    
            var pincode2Parameter = pincode2.HasValue ?
                new ObjectParameter("Pincode2", pincode2) :
                new ObjectParameter("Pincode2", typeof(long));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var isSellerParameter = isSeller.HasValue ?
                new ObjectParameter("IsSeller", isSeller) :
                new ObjectParameter("IsSeller", typeof(bool));
    
            var businessTypeParameter = businessType != null ?
                new ObjectParameter("BusinessType", businessType) :
                new ObjectParameter("BusinessType", typeof(string));
    
            var bankNameParameter = bankName != null ?
                new ObjectParameter("BankName", bankName) :
                new ObjectParameter("BankName", typeof(string));
    
            var accountNumberParameter = accountNumber != null ?
                new ObjectParameter("AccountNumber", accountNumber) :
                new ObjectParameter("AccountNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRegisterUser_Sk", firstNameParameter, middleNameParameter, lastNameParameter, emailParameter, passwordParameter, imageParameter, mobileParameter, cityName1Parameter, pincode1Parameter, type1Parameter, address1Parameter, type2Parameter, cityName2Parameter, pincode2Parameter, address2Parameter, isSellerParameter, businessTypeParameter, bankNameParameter, accountNumberParameter);
        }
    
        public virtual int spAddShippingMethod_Sk(Nullable<int> uSERID, Nullable<int> oRDERID, string shippingMethod)
        {
            var uSERIDParameter = uSERID.HasValue ?
                new ObjectParameter("USERID", uSERID) :
                new ObjectParameter("USERID", typeof(int));
    
            var oRDERIDParameter = oRDERID.HasValue ?
                new ObjectParameter("ORDERID", oRDERID) :
                new ObjectParameter("ORDERID", typeof(int));
    
            var shippingMethodParameter = shippingMethod != null ?
                new ObjectParameter("ShippingMethod", shippingMethod) :
                new ObjectParameter("ShippingMethod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddShippingMethod_Sk", uSERIDParameter, oRDERIDParameter, shippingMethodParameter);
        }
    
        public virtual ObjectResult<spSellerRequests_Sk_Result> spSellerRequests_Sk()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSellerRequests_Sk_Result>("spSellerRequests_Sk");
        }
    
        public virtual int spRemoveOrder_Sk(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRemoveOrder_Sk", userIdParameter);
        }
    }
}
