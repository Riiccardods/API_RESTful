using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using WebAPI.Data;




var builder = WebApplication.CreateBuilder(args);







// Adicionar os serviços
builder.Services.AddControllers(); /*Registra os controladores que você vai criar para manipular as requisições HTTP*/
/*Abaixo colocar*/




////aqui codigo que nao tenho que decorar
builder.Services.AddDbContext<MeuContexto>(options => /*configura o contexto do Entity Framework Core para interagir com o banco de dados.*/
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoAzureSQL"))); /*configura o contexto do Entity Framework Core para interagir com o banco de dados.*/
////aqui codigo que nao tenho que decorar






// Swagger//
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


// Configure the HTTP request pipeline.


      //Isso aqui serve para deixar o Swagger rodando em todos os modos. eu comentei o if

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
