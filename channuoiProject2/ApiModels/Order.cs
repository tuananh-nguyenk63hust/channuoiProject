namespace channuoiProject2.ApiModels
{
    public class Order
    {
        public typeOrder Type { get; set; }
    }
    public class OrderDichBenh : Order
    {
        public int DichBenh { get; set; }
        public int ThuNuoiId { get; set; }
    }
    public class OrderTinhThanh : Order
    {
        public int Tinh { get; set; }
    }
    public class PostModer: Order
    {
        public postModer postMode { get; set; }   
    }

    public class GetPaper: Order
    {
        public int Id { get; set; } 
    }
    public class AddVaccin : PostModer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public giasuc giasuc { get; set; }  
    }
    public class AddTiemPhong : PostModer
    {
        public int VaccinId { get; set; }
        public int OdichId { get; set; }
        public string VaccinName { get; set; }
        public int Thoigiantiem { get; set; }
        public int Soluongdatiem { get; set; }
        public int Soluongchuatiem { get; set; }
    }
    public class AddDichBenh : PostModer
    {
        public string Name { get; set; }
        public giasuc Giasuc { get; set; }
        public int VaccinId { get; set; }
    }
    public class AddODich : PostModer
    {
        public string Name { get; set; }
        public string Vitri { get; set; }
        public giasuc Giasuc { get; set; }
        public int Soluong { get; set; }
    }
    public class AddCoso : PostModer
    {
        public string Name { get; set; }
        public int time { get; set; }
        public giasuc giasuc { get; set; }
    }
    public class AddLuatPhap: PostModer
    {
        public string Name { get; set; }
        public string Link { get; set; } 
    }
    public enum giasuc
    {
        ga=0,
        bo=1,
        lon=2,
        vit=3
    }
    public enum typeOrder
    {
        query = 1,
        post = 2
    }
    public enum postModer
    {
        addodich =1,
        adddichbenh =2,
        addtiemphong =3,
        addtrieutrung =4,
        addvaccin =5
    }
    public class Result
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public Result (int status, string message)
        {
            this.Status = status;   
            this.Message = message;
        }
    }

    public class GetCoso
    {
        public int Id { get; set; } = -1;
    }
    public class GetLuatPhap
    {
        public int Id { get; set; } = -1;
    }
    public class GetDichBenh
    {
        public int Id { get; set; } = -1;
    }
    public class GetOdich
    {
        public int Id { get; set; } = -1;
    }
    public class GetVaccin
    {
        public int Id { get; set; } = -1;
    }

}
