using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SAKURA.Pages
{
    public class DetailModel : PageModel
    {

        public string[] ImageUrls {get; set;} = Array.Empty<string>();
        public string ProductName {get; set;} = "";
        public decimal Price{get; set;}
        public string Description{get;set;}="";

        public void OnGet(int id)
        {
            if(id == 1)
            {
                ImageUrls = new string[]{
                    "prj/SAKURA Bloom Crewneck.png",
                    "prj/SAKURA Bloom Crewneck-white.png"
                };
                ProductName = "SAKURA Bloom Crewneck";
                Price = 720000;
                Description = "SAKURA Bloom Crewneck là mẫu áo dài tay unisex mang phong cách tối giản kết hợp với họa tiết hoa anh đào đặc trưng của thương hiệu SAKURA. Thiết kế nền đen cùng các chi tiết hoa màu hồng tạo điểm nhấn tinh tế, phù hợp cho những ai yêu thích phong cách hiện đại và thanh lịch.:";
            }
            if(id == 2){
                ImageUrls = new string[]{
                    "prj/SAKURA Blossom Jersey.png"
                };
                ProductName = "SAKURA Blossom Jersey";
                Price = 470000;
                Description ="Lấy cảm hứng từ vẻ đẹp nhẹ nhàng của hoa anh đào Nhật Bản, SAKURA Blossom Varsity Jersey mang phong cách thể thao kết hợp thời trang đường phố hiện đại. Tông màu hồng pastel cùng các đường sọc dọc tạo cảm giác trẻ trung, thanh lịch và dễ phối đồ.";
            }
            if(id == 3){
                ImageUrls = new string[]{
                    "prj/SAKURA Noir Wide Pants.png"
                };
                 ProductName = "SAKURA Noir Wide Pants";
                Price = 500000;
                Description = "SAKURA Noir Wide Pants là mẫu quần ống rộng unisex mang phong cách streetwear hiện đại, lấy cảm hứng từ vẻ đẹp tinh tế của hoa anh đào Nhật Bản. Thiết kế tối giản với tông màu đen chủ đạo kết hợp họa tiết hoa anh đào và cánh hoa trắng chạy dọc thân quần tạo điểm nhấn nổi bật nhưng vẫn giữ được vẻ sang trọng và dễ phối đồ.";
             }
             if(id == 4){
                 ImageUrls = new string[]{
                    "prj/SAKURA Bloom Raglan LS.png"
                };
                 ProductName = "SAKURA Bloom Raglan LS";
                Price = 750000;
                Description ="SAKURA Bloom Raglan Long Sleeve là mẫu áo thun tay dài unisex mang phong cách Minimal Streetwear, kết hợp giữa gam màu kem và xanh navy tạo nên vẻ ngoài thanh lịch, hiện đại. Điểm nhấn nổi bật là họa tiết hoa anh đào được bố trí dọc hai tay áo cùng logo SAKURA ở mặt trước, mang đến nét tinh tế nhưng vẫn đậm dấu ấn thương hiệu.";
             }
             if(id == 5){
                 ImageUrls = new string[]{
                    "prj/SAKURA Bloom socks.png",
                    "prj/SAKURA Bloom Socks-black.png"
                };
                 ProductName = "SAKURA Bloom sock";
                Price = 70000;
                Description ="Lấy cảm hứng từ vẻ đẹp thanh khiết của hoa anh đào Nhật Bản, SAKURA Bloom Crew Socks mang phong cách tối giản nhưng tinh tế. Thiết kế nền trắng kết hợp họa tiết hoa sakura thêu nổi màu hồng tạo điểm nhấn nhẹ nhàng, phù hợp với nhiều phong cách thời trang từ casual đến streetwear.";
             }
             if(id == 6){
                ImageUrls = new string[]{
                    "prj/SAKURA Essence Shorts.png",
                    "prj/SAKURA Essence Shorts-Brown.png",
                    "prj/SKURA Essence Shorts-Gray.png"
                };
                 ProductName = "SAKURA Essence Shorts";
                Price = 450000;
                Description ="SAKURA Essence Shorts là mẫu quần short unisex mang phong cách tối giản, hiện đại, phù hợp cho cả nam và nữ. Thiết kế màu đen kết hợp logo SAKURA cùng họa tiết hoa anh đào tinh tế tạo nên vẻ ngoài sang trọng nhưng vẫn trẻ trung. Form quần rộng vừa phải mang lại cảm giác thoải mái trong mọi hoạt động hằng ngày.";
             }
             if(id == 7){
                ImageUrls = new string[]{
                    "prj/SAKURA Blossom Backpack.png"
                };
                 ProductName = "SAKURA Blossom Backpack";
                Price = 650000;
                Description ="SAKURA Blossom Backpack là mẫu balo tối giản mang phong cách Hàn Quốc, nổi bật với tông màu đen sang trọng kết hợp logo SAKURA và charm hoa anh đào màu hồng tinh tế. Thiết kế hiện đại cùng không gian lưu trữ rộng rãi giúp sản phẩm phù hợp cho học tập, làm việc và di chuyển hằng ngày.";
             }
             if(id == 8){
                ImageUrls = new string[]{
                    "prj/SAKURA Petal Whisper Long Sleeve.png"
                };
                 ProductName = "SAKURA PETAL Whisper Long Sleeve";
                Price = 700000;
                Description ="Mang phong cách tối giản kết hợp nét đẹp tinh tế của hoa anh đào, SAKURA Bloom Crewneck Long Sleeve  White là lựa chọn hoàn hảo cho những ai yêu thích thời trang Hàn Quốc hiện đại. Thiết kế nổi bật với logo SAKURA cùng họa tiết hoa anh đào hồng nhẹ nhàng được bố trí tinh tế trên ngực, tay áo và thân áo, tạo cảm giác thanh lịch nhưng vẫn trẻ trung.";
             }
             if(id == 9){
                ImageUrls = new string[]{
                    "prj/SAKURA Blossom Raglan.png"
                };
                 ProductName = "SAKURA Blossom Raglan";
                Price = 720000;
                Description ="Lấy cảm hứng từ vẻ đẹp dịu dàng của hoa anh đào, SAKURA Blossom Raglan Long Sleeve mang phong cách Hàn Quốc trẻ trung với sự kết hợp hài hòa giữa thân áo màu trắng và tay áo hồng pastel. Thiết kế Raglan hiện đại giúp tôn dáng, tạo cảm giác năng động nhưng vẫn thanh lịch. Logo hoa anh đào cùng dòng chữ SAKURA Clothing được đặt tinh tế trước ngực, mang đến điểm nhấn tối giản và cao cấp.";
             }
             if(id == 10){
                 ImageUrls = new string[]{
                    "prj/SAKURA Shadow Wide Jeans.png"
                };
                 ProductName = "SAKURA Shadow Wide Jeans";
                Price = 620000;
                Description = "SAKURA Shadow Wide Jeans là mẫu quần jeans ống rộng mang phong cách Minimalist Streetwear với gam màu đen wash cá tính. Thiết kế nổi bật bằng điểm nhấn thêu hoa anh đào màu hồng ở túi trước, tạo nên sự cân bằng giữa vẻ mạnh mẽ và nét tinh tế đặc trưng của thương hiệu SAKURA. Form quần rộng thoải mái, dễ phối với áo thun, hoodie hoặc sơ mi oversize.";
             }
             if( id == 11){
                 ImageUrls = new string[]{
                    "prj/SAKURA Blossom Keychain.png"
                };
                 ProductName = "SAKURA Blossom Keychain";
                Price = 50000;
                Description = "Móc khóa SAKURA được thiết kế theo phong cách tối giản nhưng sang trọng, lấy cảm hứng từ vẻ đẹp của hoa anh đào Nhật Bản. Sản phẩm nổi bật với mặt charm hình hoa sakura phủ men hồng cao cấp kết hợp cùng chi tiết kim loại sáng bóng, tạo nên vẻ tinh tế và hiện đại. Đây là phụ kiện hoàn hảo để trang trí chìa khóa, balo, túi xách hoặc làm quà tặng.";
             }
             if( id == 12){
                 ImageUrls = new string[]{
                    "prj/SAKURA Blossom Baseball Shirt.png"
                };
                 ProductName = "SAKURA Blossom Baseball Shirt";
                Price = 500000;
                Description ="Áo Baseball SAKURA Blossom Pinstripe mang phong cách thể thao kết hợp thời trang đường phố hiện đại. Thiết kế nổi bật với nền hồng pastel phối họa tiết sọc dọc trắng, logo SAKURA thêu nổi trước ngực cùng biểu tượng hoa anh đào tinh tế. Form áo rộng (Oversized) phù hợp cho cả nam và nữ, dễ phối với quần jean, quần short hoặc chân váy.";
             }
             if(id == 13){
                 ImageUrls = new string[]{
                    "prj/SAKURA Blush Oxford Shirt.png"
                };
                 ProductName = "SAKURA Blush Oxford Shirt";
                Price = 400000;
                Description ="Áo sơ mi Oxford SAKURA Blush mang phong cách tối giản, thanh lịch và hiện đại. Thiết kế với gam màu hồng pastel nhẹ nhàng, kết hợp logo hoa anh đào thêu tinh xảo trên túi ngực, tạo điểm nhấn sang trọng. Form áo Oversized Unisex giúp dễ dàng phối đồ, phù hợp cho cả nam và nữ trong nhiều hoàn cảnh.";
             }
             if( id == 14){
                ImageUrls = new string[]{
                    "prj/SAKURA Petal Tee.png"
                };
                 ProductName = "SAKURA Petal Tee";
                Price = 420000;
                Description ="SAKURA Blossom Tee mang đến vẻ đẹp trẻ trung, nhẹ nhàng và tinh tế với thiết kế áo thun trắng điểm xuyết họa tiết hoa anh đào nhỏ xinh. Phần cổ áo và tay áo được phối viền hồng pastel, tạo điểm nhấn hài hòa và nữ tính. Logo SAKURA được đặt tinh tế trên ngực áo, thể hiện phong cách tối giản nhưng vẫn nổi bật.";
             }
             if(id == 15){
                ImageUrls = new string[]{
                    "prj/SAKURA Pink Blossom Tee.png"
                };
                 ProductName = "SAKURA Pink Blossom Tee";
                Price = 700000;
                Description ="Áo Raglan SAKURA Pink Blossom sở hữu thiết kế trẻ trung với thân áo màu trắng kết hợp tay áo hồng pastel nổi bật. Điểm nhấn là logo SAKURA in trên túi ngực cùng họa tiết chữ SAKURA chạy dọc tay áo, mang phong cách Hàn Quốc hiện đại. Form áo rộng vừa phải, phù hợp cho cả nam và nữ.";
             }
             if(id == 16){
                ImageUrls = new string[]{
                   "prj/SAKURA VIBE T-Shirt.png"
                };
                 ProductName = "SAKURA VIBE T-Shirt";
                Price = 350000;
                Description ="Áo Thun Oversized SAKURA VIBE Blossom mang phong cách streetwear hiện đại với gam màu xanh navy sang trọng. Điểm nhấn là dòng chữ VIBE kết hợp cùng họa tiết hoa anh đào nở rộ ở mặt trước, tạo nên vẻ ngoài trẻ trung và cá tính. Form Oversized rộng rãi giúp mang lại cảm giác thoải mái, phù hợp cho cả nam và nữ.";
             }
             if(id == 17){
                ImageUrls = new string[]{
                  "prj/SAKURA Petal Signature Tee.png"
                };
                 ProductName = "SAKURA Petal Signature Tee";
                Price = 450000;
                Description ="Áo Thun Oversized SAKURA Petal Signature mang phong cách tối giản, hiện đại với tông màu xám trắng thanh lịch. Điểm nhấn là logo SAKURA kết hợp cùng họa tiết hoa anh đào và dòng chữ EST. 2026, tạo nên vẻ ngoài tinh tế nhưng vẫn  nổi bật. Thiết kế Unisex phù hợp cho cả nam và nữ, dễ dàng phối với nhiều phong cách thời trang.";
             }
             if(id == 18){
                ImageUrls = new string[]{
                 "prj/SAKURA Vietnam Blossom Jacket.png"
                };
                 ProductName = "SAKURA Vietnam Blossom Jacket";
                Price = 450000;
                Description ="Áo Khoác Bomber SAKURA Vietnam Blossom là sự kết hợp giữa phong cách streetwear hiện đại và vẻ đẹp truyền thống của hoa anh đào. Thiết kế nổi bật với họa tiết cành hoa anh đào nở rộ trải đều trên thân và tay áo, tạo cảm giác tinh tế, sang trọng. Điểm nhấn là logo SAKURA cùng biểu tượng lấy cảm hứng từ quốc kỳ Việt Nam ở ngực trái, thể hiện tinh thần trẻ trung và bản sắc riêng của thương hiệu";
             }
             if(id == 19){
                ImageUrls = new string[]{
                  "prj/SAKURA Noir Dots Backpack.png"
                };
                 ProductName = "SAKURA Noir Dots Backpack";
                Price = 450000;
                Description ="Balo Canvas SAKURA Noir Dots sở hữu thiết kế tối giản với tông màu đen phối họa tiết chấm bi trắng hiện đại, kết hợp logo SAKURA cùng biểu tượng hoa anh đào ở mặt trước. Kiểu dáng trẻ trung, dung tích rộng rãi và nhiều ngăn tiện lợi giúp đáp ứng nhu cầu sử dụng hằng ngày, phù hợp cho học sinh, sinh viên và nhân viên văn phòng.";
             }
             if(id == 20){
                ImageUrls = new string[]{
                  "prj/SAKURA Floral Elegance Tee.png"
                };
                 ProductName = "SAKURA Floral Elegance Tee";
                Price = 320000;
                Description = "Áo Thun Tay Dài SAKURA Floral Elegance mang phong cách thanh lịch và nữ tính với thiết kế tối giản trên nền trắng tinh khôi. Điểm nhấn là họa tiết cành hoa anh đào được minh họa bằng nét vẽ nghệ thuật kết hợp chiếc nơ duyên dáng cùng dòng chữ Sakura Blossom, tạo nên vẻ đẹp nhẹ nhàng, tinh tế. Form áo rộng vừa phải, mang lại cảm giác thoải mái và dễ phối với nhiều phong cách thời trang.";
             }
             if(id == 21){
                ImageUrls = new string[]{
                  "prj/SAKURA Noir Card Holder.png"
                };
                 ProductName = "SAKURA Noir Card Holder";
                Price = 100000;
                Description = "Ví đựng thẻ SAKURA Noir Card Holder mang phong cách tối giản, sang trọng với gam màu đen chủ đạo kết hợp logo hoa anh đào màu hồng nổi bật. Thiết kế mỏng nhẹ giúp dễ dàng cất trong túi quần, túi xách hoặc balo mà không gây cộm. Phù hợp cho học sinh, sinh viên, nhân viên văn phòng và những người yêu thích phong cách thanh lịch.";
         }
        }
    }
}