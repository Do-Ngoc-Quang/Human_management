SELECT ns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietphongvan as ctpv on ctpv.manhanvien = ns.manhansu 
WHERE ns.manhansu LIKE '%%' AND ns.ishienthi = true AND ctpv.ishoantatquatrinh = false
OR ns.hoten LIKE '%%' AND ns.ishienthi = true AND ctpv.ishoantatquatrinh = false;