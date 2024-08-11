//using Microsoft.AspNetCore.Mvc;
//using OtelRezervasyon.BusinessLayer.Abstracts;
//using OtelRezervasyon.EntityLayer.Concrete;
//using System.Collections.Generic;

//public class PdfController : Controller
//{
//    private readonly IPdfService _pdfService;
//    private readonly IRoomService _roomService;

//    public PdfController(IPdfService pdfService, IRoomService roomService)
//    {
//        _pdfService = pdfService;
//        _roomService = roomService;
//    }

//    [HttpGet]
//    public IActionResult DownloadPdf()
//    {
//        // Veritabanından oda verilerini alın
//        var listData = GetListData();

//        // HTML içeriği oluşturun
//        string htmlContent = GenerateHtmlContent(listData);

//        // PDF oluşturun
//        byte[] pdfBytes = _pdfService.GeneratePdf(htmlContent);

//        return File(pdfBytes, "application/pdf", "ListData.pdf");
//    }

//    private List<Rooms> GetListData()
//    {
//        // Burada veritabanından veri çekin (RoomService kullanarak)
//        return _roomService.TGetListAll();
//    }

//    private string GenerateHtmlContent(List<Rooms> listData)
//    {
//        // HTML içeriği oluşturun
//        string htmlContent = "<html><body><h1>Room List</h1><ul>";
//        foreach (var room in listData)
//        {
//            htmlContent += $"<li>{room.RoomName} - {room.Description} - Capacity: {room.Capacity}</li>";
//        }
//        htmlContent += "</ul></body></html>";
//        return htmlContent;
//    }
//}