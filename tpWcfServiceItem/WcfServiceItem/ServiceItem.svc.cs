using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ItemDll;

namespace WcfServiceItem
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceItem" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceItem.svc ou ServiceItem.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceItem : IServiceItem
    {
        public Item GetItemByParameter(string Marque, int Prix)
        {
            return new Item(Marque, Prix);
        }

        public Item UpdateItem(Item i)
        {
            i.Prix += i.Prix * 20 / 100;
            i.Marque = i.Marque.ToUpper();
            return i;
        }

        public List<Item> GetListItem()
        {
            List<Item> l = new List<Item>();
            l.Add(new Item( "GameBoy", 100));
            l.Add(new Item( "Psone", 150));
            l.Add(new Item( "GameCube", 200));

            return l;
        }
        public List<Item> SelectAll()
        {
            return new Db().SelectAll();
        }

        public void Insert(String Marque, double Prix)
        {
            new Db().Insert(Marque, Prix);
        }

    }
}
