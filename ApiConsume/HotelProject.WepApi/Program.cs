using HotelProject.BAL.Abstract;
using HotelProject.BAL.Concrete;
using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;
using HotelProject.DAL.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<DataContext>();

builder.Services.AddScoped<IStaffRepo , EfStaffRepo>();
builder.Services.AddScoped<IStaffService , StaffManager>();

builder.Services.AddScoped<IRoomRepo , EfRoomRepo>();
builder.Services.AddScoped<IRoomService , RoomManager>();

builder.Services.AddScoped<ITestimonialRepo , EfTestimonialRepo>();
builder.Services.AddScoped<ITestimonialService , TestimonialManager>();

builder.Services.AddScoped<ISubscribeRepo , EfSubscribeRepo>();
builder.Services.AddScoped<ISubscribeService , SubscribeManager>();

builder.Services.AddScoped<IServiceRepo , EfServiceRepo>();
builder.Services.AddScoped<IServiceService , ServiceManager>();

builder.Services.AddScoped<IAboutRepo , EfAboutRepo>();
builder.Services.AddScoped<IAboutService , AboutManager>();


builder.Services.AddScoped<IBookingRepo , EfBookingRepo>();
builder.Services.AddScoped<IBookingService , BookingManager>();


builder.Services.AddAutoMapper(typeof(Program));
//builder.Services.AddScoped<>()
builder.Services.AddHttpClient();


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("OtelApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();