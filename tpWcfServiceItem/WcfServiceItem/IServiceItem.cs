using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ItemDll;

namespace WcfServiceItem
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceItem" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceItem
    {
        [OperationContract]
        Item GetItemByParameter(string Marque, int Prix);

        [OperationContract]
        Item UpdateItem(Item i);

        [OperationContract]
        void Insert(String Marque, double Prix);

        [OperationContract]
        List<Item> GetListItem();

        [OperationContract]
        List<Item> SelectAll();
    }
}
