using static System.Console;

namespace Ex_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.NameProduct = "Автомобиль";
            product.NumberProduct = 5674;
            product.ColorProduct = "Черный";
            product.ConclusionProduct(product.NameProduct, product.NumberProduct,product.ColorProduct);

            Note note = new Note();
            note.NameNote = "Двигатель";
            note.TypeNote = "Бензиновый";

            Mechanism mechanism = new Mechanism();
            mechanism.NameMechanism = "Газорасприделительный";
            mechanism.ConclusionNote(product.NameProduct, product.NumberProduct, note.NameNote, note.TypeNote);
            mechanism.ConclusionMechanism(product.NumberProduct, note.TypeNote, mechanism.NameMechanism);

            Detail detail = new Detail();
            detail.NameDetail = "Клапан";
            detail.MaterialDetail = "Кремниевая легированная сталь";
            detail.ConclusionDetail(detail.NameDetail, detail.MaterialDetail);
            detail.Material(product.NameProduct,detail.NameDetail, detail.MaterialDetail);
        }
    }
}