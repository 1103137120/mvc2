using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSaleDao
{
    public class OrderDao
    {
        /// <summary>
        /// 依訂單編號取得訂單資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public eSaleModel.Order GetOrderById(String id) {
            return new eSaleModel.Order()
            { CustId = "KUAS", CustName = "高應大", OrderId = "1" };

        }
    }
}
