using BuilderChallenge;


Console.WriteLine("=== Sistema de Relatórios ===");

var report1 = new ReportBuilder()
    .SetTitle("Vendas Mensais")
    .SetFormat("PDF")
    .SetStartDate(new DateTime(2024, 1, 1))
    .SetEndDate(new DateTime(2024, 1, 31))
    .IncludeHeader(true, "Relatório de Vendas")
    .IncludeFooter(true, "Confidencial")
    .IncludeCharts(true, "Bar")
    .AddColumn("Produto")
    .AddColumn("Quantidade")
    .AddColumn("Valor")
    .AddFilter("Status=Ativo")
    .SetSortBy("Valor")
    .SetGroupBy("Categoria")
    .IncludeTotals(true)
    .SetOrientation("Portrait")
    .SetPageSize("A4")
    .IncludePageNumbers(true)
    .SetCompanyLogo("logo.png")
    .SetWaterMark("Confidencial")
    .Build();

report1.Generate();

var report2 = new ReportBuilder()
    .SetTitle("Relatório Trimestral")
    .SetFormat("Excel")
    .SetStartDate(new DateTime(2024, 1, 1))
    .SetEndDate(new DateTime(2024, 3, 31))
    .AddColumn("Vendedor")
    .AddColumn("Região")
    .AddColumn("Total")
    .IncludeCharts(true, "Line")
    .IncludeHeader(true)
    .SetGroupBy("Região")
    .IncludeTotals(true)
    .Build();

report2.Generate();


var report3 = new ReportBuilder()
    .SetTitle("Vendas Anuais")
    .SetFormat("PDF")
    .SetStartDate(new DateTime(2024, 1, 1))
    .SetEndDate(new DateTime(2024, 12, 31))
    .IncludeHeader(true, "Relatório de Vendas")
    .IncludeFooter(true, "Confidencial")
    .AddColumn("Produto")
    .AddColumn("Quantidade")
    .AddColumn("Valor")
    .IncludeCharts(true, "Pie")
    .IncludeTotals(true)
    .SetOrientation("Landscape")
    .SetPageSize("A4")
    .Build();

report3.Generate();
