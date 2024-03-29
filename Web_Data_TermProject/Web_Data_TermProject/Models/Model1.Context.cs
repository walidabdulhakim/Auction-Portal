﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Data_TermProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class termprjEntities17 : DbContext
    {
        public termprjEntities17()
            : base("name=termprjEntities17")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Reserve> Reserves { get; set; }
        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Auction> Auctions { get; set; }
        public virtual DbSet<itemInfo> itemInfoes { get; set; }
        public virtual DbSet<WinRecord> WinRecords { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Userinfo> Userinfoes { get; set; }
        public virtual DbSet<message> messages { get; set; }
        public virtual DbSet<AccountsVie> AccountsVies { get; set; }
        public virtual DbSet<Auction_view> Auction_view { get; set; }
        public virtual DbSet<Reserv_view> Reserv_view { get; set; }
        public virtual DbSet<User_View> User_View { get; set; }
    
        public virtual int Bit_alter(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Bit_alter", idParameter, nameParameter);
        }
    
        public virtual int add_win(string name, Nullable<int> ammount, string auctionName)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var ammountParameter = ammount.HasValue ?
                new ObjectParameter("ammount", ammount) :
                new ObjectParameter("ammount", typeof(int));
    
            var auctionNameParameter = auctionName != null ?
                new ObjectParameter("AuctionName", auctionName) :
                new ObjectParameter("AuctionName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("add_win", nameParameter, ammountParameter, auctionNameParameter);
        }
    
        public virtual int del_auc(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_auc", idParameter);
        }
    
        public virtual int del_bid(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_bid", idParameter);
        }
    
        public virtual int del_items(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_items", idParameter);
        }
    
        public virtual int del_mess(string mess)
        {
            var messParameter = mess != null ?
                new ObjectParameter("mess", mess) :
                new ObjectParameter("mess", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("del_mess", messParameter);
        }
    
        public virtual int edit_auction(Nullable<int> id, string make, string type, string model, Nullable<int> year)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var makeParameter = make != null ?
                new ObjectParameter("make", make) :
                new ObjectParameter("make", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("edit_auction", idParameter, makeParameter, typeParameter, modelParameter, yearParameter);
        }
    
        public virtual int edit_auction1(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("edit_auction1", idParameter, nameParameter);
        }
    
        public virtual int edit_userinfo(Nullable<int> id, string email, string name, string surname, string telephone)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("telephone", telephone) :
                new ObjectParameter("telephone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("edit_userinfo", idParameter, emailParameter, nameParameter, surnameParameter, telephoneParameter);
        }
    
        public virtual int edit_userlogin(Nullable<int> id, string email, string password)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("edit_userlogin", idParameter, emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<getinfo_Result> getinfo(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getinfo_Result>("getinfo", nameParameter);
        }
    
        public virtual int getrecord(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getrecord", nameParameter);
        }
    
        public virtual int update_reccar(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_reccar", usernameParameter);
        }
    
        public virtual int update_reclog(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_reclog", usernameParameter);
        }
    
        public virtual int Delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete", idParameter);
        }
    
        public virtual int Delete_m(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_m", idParameter);
        }
    
        public virtual int Deleteinfo(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Deleteinfo", idParameter);
        }
    }
}
