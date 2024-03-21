using HtmlAgilityPack;

namespace TI.Laba1;

public class Program
{
    private enum Mode
    {
        Set,
        Remove
    }
    private static void ChangeIndexHtml(string tag, string id, string? text, Mode mode)
    {
        var filePath = "wwwroot/index.html";
        var html = File.ReadAllText(filePath);
        var doc = new HtmlDocument();
        doc.LoadHtml(html);
        var contentNode = doc.DocumentNode.SelectSingleNode($"//{tag}[@id='{id}']");
        if (tag == "option")
        {
            if (mode == Mode.Set)
                contentNode.SetAttributeValue("selected", "selected");
            else
                contentNode.Attributes.Remove("selected");
        }
        else if (tag == "input")
        {
            contentNode.SetAttributeValue("value", $"{text}");
        }
        else
            contentNode.InnerHtml = $"{text}";
        File.WriteAllText(filePath, doc.DocumentNode.OuterHtml);
    }
    
    public static void Main()
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();
        
        app.Run(async (context) =>
        {
            var path = context.Request.Path;
            if (path == "/text")
            {
                var form = context.Request.Form;
                string? method = form["method"];
                string? regime = form["regime"];
                string? key = form["key"];
                string? src = form["src"];
                string? dest = null;
                if (method == "dec" && regime == "encrypt")
                    dest = Decimations.Encrypt(src, key);
                else if (method == "dec" && regime == "decrypt")
                    dest = Decimations.Decrypt(src, key);
                else if (method == "vig" && regime == "encrypt")
                    dest = Vigenere.Encrypt(src, key);
                else if (method == "vig" && regime == "decrypt")
                    dest = Vigenere.Decrypt(src, key);
                
                ChangeIndexHtml("textarea", "src", src, Mode.Set);
                ChangeIndexHtml("textarea", "dest", dest, Mode.Set);
                
                ChangeIndexHtml("input", "text-num", key, Mode.Set);
                
                ChangeIndexHtml("option", method == "dec" ? "vig-text" : "dec-text", null, Mode.Remove);
                ChangeIndexHtml("option", $"{method}-text", null, Mode.Set);
                    
                ChangeIndexHtml("option", regime == "encrypt" ? "decrypt-text" : "encrypt-text", null, Mode.Remove);
                ChangeIndexHtml("option", $"{regime}-text", null, Mode.Set);

            } 
            else if (path == "/file")
            {
                string? text = null;
                
                var form = context.Request.Form;
                string? method = form["method"];
                string? regime = form["regime"];
                string? key = form["key"];
                var files = form.Files;
                
                var uploadPath = $"{Directory.GetCurrentDirectory()}/upload";
                var resultPath = $"{Directory.GetCurrentDirectory()}/result";
                Directory.CreateDirectory(uploadPath);
                Directory.CreateDirectory(resultPath);
                
                foreach (var file in files) {
                    
                    var fullPath = $"{uploadPath}/{file.FileName}";
                    using (var fileStream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    text = File.ReadAllText(fullPath);
                    fullPath = $"{resultPath}/{file.FileName}";
                    using (var fileStream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    
                    if (method == "dec" && regime == "encrypt")
                        text = Decimations.Encrypt(text, key);
                    else if (method == "dec" && regime == "decrypt")
                        text = Decimations.Decrypt(text, key);
                    else if (method == "vig" && regime == "encrypt")
                        text = Vigenere.Encrypt(text, key);
                    else if (method == "vig" && regime == "decrypt")
                        text = Vigenere.Decrypt(text, key);
                    
                    await File.WriteAllTextAsync(fullPath, text);
                    
                    ChangeIndexHtml("textarea", "res", text, Mode.Set);
                }
                
                ChangeIndexHtml("input", "file-num", key, Mode.Set);
                
                ChangeIndexHtml("option", method == "dec" ? $"vig-file" : $"dec-file", null, Mode.Remove);
                ChangeIndexHtml("option", $"{method}-file", null, Mode.Set);
                    
                ChangeIndexHtml("option", regime == "encrypt" ? $"decrypt-file" : $"encrypt-file", null, Mode.Remove);
                ChangeIndexHtml("option", $"{regime}-file", null, Mode.Set);
                
            }
            await context.Response.SendFileAsync("wwwroot/index.html");
        });
        app.Run();
    }
}
