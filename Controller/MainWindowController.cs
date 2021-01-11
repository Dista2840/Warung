using System;
using System.Collections.Generic;
using System.Text;
using WARUNG.Model;
using WARUNG.Model;

namespace WARUNG.Controller
{
    class MainWindowController
    {
        KeranjangBelanja keranjangBelanja;


        public MainWindowController(KeranjangBelanja keranjangBelanja, Bayar payment)
        {
            this.keranjangBelanja = keranjangBelanja;
        }

        public void addItem(Item item)
        {
            keranjangBelanja.addItem(item);
        }

        public void removeItem(Item item)
        {
            keranjangBelanja.removeItem(item);
        }

        public List<Item> getItems()
        {
            return keranjangBelanja.getItems();
        }

        public void addDiskon(Diskon diskon)
        {

            keranjangBelanja.addDiskon(diskon);
        }

        public List<Diskon> getDiskon()
        {
            return keranjangBelanja.getDiskon();
        }


    }
}
