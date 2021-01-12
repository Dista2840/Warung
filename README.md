# WARUNG
- Teuku Muhammad Dista (19.11.2840)
- S1 IF 04
- program ini adalah program yang bertujuan untuk menambahkan item ke sebuah keranjang digital dan menambahkan voucher belanja

## Scope of Functions
- menambahkan barang dengan tehnik MVC 
- melihat daftar makan minum yang di tawarkan
- penambahan fungsi Voucer serta dapat melihat total harga setelah di potong 
- penambahan message box pada saat menghapus item

### How does it works ? 
- fungsi MainWindowController.cs digunakan untuk melakukan beberapa operasi. Seperti menambahkan item dan voucher, menghapus item dan voucher, lalu untuk mendapatkan data list dari item yang dibeli dan voucher yang digunakan.
- model yang digunakan yaitu model item untuk makanan atau minuman, model keranjangBelanja untuk menaruh pembelian, model payment untuk mengurusi total harga beli, dan model Voucher untuk daftar vouchernya
- Alur program :
- menu yang ditawarkan : 

 ```c#
  private void generateContentMenu()
        {
            Item Menu1 = new Item("Coffe Late", 30000);
            Item Menu2 = new Item("Black Tea", 20000);
            Item Menu3 = new Item("Pizza", 75000);
            Item Menu4 = new Item("Milk Shake", 15000);
            Item Menu5 = new Item("Fried Frice Special", 45000);
            Item Menu6 = new Item("Watermelon Juice", 25000);
            Item Menu7 = new Item("Lemon Squash", 30000);

            menuController.addItem(Menu1);
            menuController.addItem(Menu2);
            menuController.addItem(Menu3);
            menuController.addItem(Menu4);
            menuController.addItem(Menu5);
            menuController.addItem(Menu6);
            menuController.addItem(Menu7);

            listMenu.Items.Refresh();

        }
        
  ```
        
- voucher nya :
 ```c#
 
 private void generateContentPromo()
        {
            Diskon diskon1 = new Diskon("Promo Awal tahun Diskon 25 % ", 25000);
            Diskon diskon2 = new Diskon("Promo Tebus Murah Diskon 30 % atau maksimal 30.000", 30000);
            Diskon diskon3 = new Diskon("Promo Natal Potongan 10000", 10000);

            promoController.addPromo(diskon1);
            promoController.addPromo(diskon2);
            promoController.addPromo(diskon3);

            listBoxDaftarPromo.Items.Refresh();
        }
        
  
 ```
 
 - keranjang pesanan untuk menampilkan belanjaan dan voucher :
  ```c#
  
  namespace WARUNG.Model
{
    class KeranjangBelanja
    {
        List<Item> itemkeranjangBelanja;
        public List<Diskon> diskonDipakai;
        Bayar payment;
        onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener;

        public KeranjangBelanja(Bayar payment, onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener)
        {
            this.payment = payment;
            this.onKeranjangBelanjaChangedListener = onKeranjangBelanjaChangedListener;
            this.itemkeranjangBelanja = new List<Item>();
            this.diskonDipakai = new List<Diskon>();
        }
        public List<Item> getItems()
        {
            return this.itemkeranjangBelanja;
        }

        public List<Diskon> getDiskon()
        {
            return this.diskonDipakai;
        }
        
 ```    
        

### Tools
- Visual Studio 2019
- C# Langugage
 
 Terimakasihh..

 
 
<img width="248" alt="Screenshot (61)" src="https://user-images.githubusercontent.com/61915433/104282508-c38b6780-54e1-11eb-8744-d7a3c44a002d.png"> <img width="568" alt="Screenshot (60)" src="https://user-images.githubusercontent.com/61915433/104282618-e7e74400-54e1-11eb-9e22-c4406183cda2.png">
