namespace SOLID.O
{
     public class ProductFilter{
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size){
            // var list = new List<Product>();
            foreach(var p in products){
                if(p.Size == size){
                //    list.Add(p);
                 yield return p; // returns each element one by one saving you the need for temp storage for the iteration 
                }
            }
            // return list;
        }

        //OLD WAY OF DOING THINGS...goes against DRY
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color){
            foreach(var p in products){
                if(p.Color == color){
                 yield return p; 
                 }
            }
        }
    }
}