//
// The following code is generated by CodeBreeze
// DO NOT modify this code module manually - make customizations to the derived class or classes.
// 
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using Csla.Data;
using CslaEx.Data;

namespace CslaStore.Data
{
    /// <summary>
    /// This class inherits from the common DAL and adds the encapsulation of each stored procedure in the database.
    /// Each method receives the stored procedure parameters as method arguments and builds the appropriate ADO.NET code to perform the data operations.
    /// </summary>
    public class DataAccess : DalBase
	{
        #region Constructors

        /// <summary>
        /// This is the default constructor and retrieves a connection string from the configuration file.
        /// </summary>
        public DataAccess()
            : base("connStr") { }

		public static void ClearConnection()
		{
			DalBase.ClearConnection("connStr");
		}
		
        #endregion

        #region Stored procedures
	
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderDelete' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderDelete(Guid orderID)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderID", orderID) as IDataParameter
			};

			return GetReader("OrderDelete", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderDetailDelete' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderDetailDelete(Guid orderDetailID)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderDetailID", orderDetailID) as IDataParameter
			};

			return GetReader("OrderDetailDelete", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderDetailGetAll' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderDetailGetAll()
		{

			return GetReader("OrderDetailGetAll", CommandType.StoredProcedure);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderDetailGetById' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderDetailGetById(Guid orderDetailID)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderDetailID", orderDetailID) as IDataParameter
			};

			return GetReader("OrderDetailGetById", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderDetailInsert' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderDetailInsert(Guid orderDetailID, Guid orderID, Guid productID, decimal purchaseUnitPrice, Int32 quantity)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderDetailID", orderDetailID) as IDataParameter,
				GetParameter("@p_OrderID", orderID) as IDataParameter,
				GetParameter("@p_ProductID", productID) as IDataParameter,
				GetParameter("@p_PurchaseUnitPrice", purchaseUnitPrice) as IDataParameter,
				GetParameter("@p_Quantity", quantity) as IDataParameter
			};

			return GetReader("OrderDetailInsert", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderDetailUpdate' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderDetailUpdate(Guid orderDetailID, Guid orderID, Guid productID, decimal purchaseUnitPrice, Int32 quantity)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderDetailID", orderDetailID) as IDataParameter,
				GetParameter("@p_OrderID", orderID) as IDataParameter,
				GetParameter("@p_ProductID", productID) as IDataParameter,
				GetParameter("@p_PurchaseUnitPrice", purchaseUnitPrice) as IDataParameter,
				GetParameter("@p_Quantity", quantity) as IDataParameter
			};

			return GetReader("OrderDetailUpdate", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderGetAll' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderGetAll()
		{

			return GetReader("OrderGetAll", CommandType.StoredProcedure);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderGetById' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderGetById(Guid orderID)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderID", orderID) as IDataParameter
			};

			return GetReader("OrderGetById", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderGetForUser' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderGetForUser(string userName)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_UserName", userName) as IDataParameter
			};

			return GetReader("OrderGetForUser", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderGetWithDetail' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderGetWithDetail(Guid orderID)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderID", orderID) as IDataParameter
			};

			return GetReader("OrderGetWithDetail", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderGetWithDetailByOrderNumber' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderGetWithDetailByOrderNumber(string orderNumber)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderNumber", orderNumber) as IDataParameter
			};

			return GetReader("OrderGetWithDetailByOrderNumber", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderInsert' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderInsert(Guid orderID, string userName, string orderNumber, DateTime orderDate, string cardType, string cardHolder, string creditCard, string expDate)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderID", orderID) as IDataParameter,
				GetParameter("@p_UserName", userName) as IDataParameter,
				GetParameter("@p_OrderNumber", orderNumber) as IDataParameter,
				GetParameter("@p_OrderDate", orderDate) as IDataParameter,
				GetParameter("@p_CardType", cardType) as IDataParameter,
				GetParameter("@p_CardHolder", cardHolder) as IDataParameter,
				GetParameter("@p_CreditCard", creditCard) as IDataParameter,
				GetParameter("@p_ExpDate", expDate) as IDataParameter
			};

			return GetReader("OrderInsert", CommandType.StoredProcedure, parameters);
		}

		
        /// <summary>
        /// Method encapsulates all data access code for the 'OrderUpdate' stored procedure.
        /// Arguments all correspond to stored procedure parameters.
        /// </summary>
        /// <Returns>A provider-specific implementation of the IDataReader interface (i.e. SqlDataReader, OleDbDataReader, etc).</Returns>
        public SafeDataReader OrderUpdate(Guid orderID, string userName, string orderNumber, DateTime orderDate, string cardType, string cardHolder, string creditCard, string expDate)
		{
			IDataParameter[] parameters =
			{
				GetParameter("@p_OrderID", orderID) as IDataParameter,
				GetParameter("@p_UserName", userName) as IDataParameter,
				GetParameter("@p_OrderNumber", orderNumber) as IDataParameter,
				GetParameter("@p_OrderDate", orderDate) as IDataParameter,
				GetParameter("@p_CardType", cardType) as IDataParameter,
				GetParameter("@p_CardHolder", cardHolder) as IDataParameter,
				GetParameter("@p_CreditCard", creditCard) as IDataParameter,
				GetParameter("@p_ExpDate", expDate) as IDataParameter
			};

			return GetReader("OrderUpdate", CommandType.StoredProcedure, parameters);
		}

				#endregion

    }
}
