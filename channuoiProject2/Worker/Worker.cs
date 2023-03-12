using channuoiProject2.ApiModels;
using Microsoft.EntityFrameworkCore;

namespace channuoiProject2
{
    public class Worker
    {
        public Database context { get; set; }
        public Worker (Database context)
        {
            this.context = context;
        }
        public async Task<bool> FuncAddVaccin (AddVaccin addVaccin)
        {
            try
            {
                vaccin vaccin = new vaccin()
                {
                    Name = addVaccin.Name,
                    Giasuc = (int) addVaccin.giasuc
                };
                context.Add<vaccin>(vaccin);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }
        public async Task<bool> FuncAddDichBenh (AddDichBenh addDichBenh)
        {
            try
            {
                dichbenh dichbenh = new dichbenh()
                {
                    DichbenhName= addDichBenh.Name,
                    GiaSuc = (int) addDichBenh.Giasuc,
                    VaccinId = addDichBenh.VaccinId
                };
                context.Add<dichbenh>(dichbenh);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> FuncAddOdich(AddODich addODich)
        {
            try
            {
                odich odich = new odich()
                {
                    OdichName= addODich.Name,
                    Vitri = addODich.Vitri,
                    Giasuc = (int) addODich.Giasuc,
                    Soluowng = addODich.Soluong
                };
                context.Add<odich>(odich);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> FuncAddCoSo(AddCoso addCoso)
        {
            try
            {
                coso coso = new coso()
                {
                    Name = addCoso.Name,
                    Loaicoso = (int)addCoso.giasuc,
                    Thoigianvanhanh = addCoso.time
                };
                context.Add<coso>(coso);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> FuncAddLuatPhap(AddLuatPhap addLuatPhap)
        {
            try
            {
                luatphap luatphap = new luatphap()
                {
                    Name = addLuatPhap.Name,
                    Link = addLuatPhap.Link,
                };
                context.Add<luatphap>(luatphap);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> FuncAddODich(AddODich addODich)
        {
            try
            {
                odich odich = new odich()
                {
                    OdichName = addODich.Name,
                    Giasuc = (int)addODich.Giasuc,
                    Vitri = addODich.Vitri,
                    Soluowng = addODich.Soluong
                };
                context.Add<odich>(odich);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> FuncAddTiemPhong(AddTiemPhong addTiemPhong)
        {
            try
            {
                tiemphong tiemphong = new tiemphong()
                {
                    VaccinId = addTiemPhong.VaccinId,
                    VaccinName = addTiemPhong.VaccinName,
                    OdichId = addTiemPhong.OdichId,
                    Thoigiantiem = addTiemPhong.Thoigiantiem,
                    Soluongchuatien = addTiemPhong.Soluongchuatiem,
                    Soluongdatiem = addTiemPhong.Soluongdatiem
                };
                context.Add<tiemphong>(tiemphong);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<coso>> Getcoso (GetCoso getcoso)
        {
            try
            {
                if (getcoso.Id == -1)
                {
                    return context.cosos.ToList();
                }
                return context.cosos.Where(s => s.Id == getcoso.Id).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<luatphap>> GetLuatPhap(GetCoso getcoso)
        {
            try
            {
                if (getcoso.Id == -1)
                {
                    return context.luatphap.ToList();
                }
                return context.luatphap.Where(s => s.Id == getcoso.Id).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<dichbenh>> GetDichBenh(GetCoso getcoso)
        {
            try
            {
                if (getcoso.Id == -1)
                {
                    return context.dichbenh.ToList();
                }
                return context.dichbenh.Where(s => s.DichbenhId == getcoso.Id).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<odich>> GetOdich(GetCoso getcoso)
        {
            try
            {
                if (getcoso.Id == -1)
                {
                    return context.odich.ToList();
                }
                return context.odich.Where(s => s.Id == getcoso.Id).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<vaccin>> GetVaccin(GetCoso getcoso)
        {
            try
            {
                if (getcoso.Id == -1)
                {
                    return context.vaccins.ToList();
                }
                return context.vaccins.Where(s => s.VaccinId == getcoso.Id).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
    }
}
