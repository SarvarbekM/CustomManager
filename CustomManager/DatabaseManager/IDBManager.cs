using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomManager.DatabaseManager
{
    public interface IDBManager
    {
        string SignIn(string login, string password);
        string Register(Customer customer);
        string IsHaveLogin(string login,ref bool answer);
        string InsertFEACN(FEACN feacn,ref bool answer);
        string InsertProduct(Product product, ref bool answer);
        string LoadProducts(ref List<Product> productList);
        string LoadRegions(ref List<Region> regionList);
        string LoadProductbyID(int id, ref Product product);
        string LoadRegionbyID(int id, ref Region region);
        string LoadLocationbyID(int id, ref Location location);
        string InsertContract(Contract contract, ref bool answer);
        string LoadContracts(ref List<Contract> contractList);
        string LoadOrdersByContractID(int contractID,ref List<Order> orderList);
        string InsertOrder(Order order, ref bool answer);
        string LoadContractByMaxid(ref Contract contract);
        string LoadFEACNbyID(int id, ref FEACN feacn);
    }
}
