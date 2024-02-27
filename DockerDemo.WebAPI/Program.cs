using DockerDemo.Data.IRepository;
using DockerDemo.Data.Repository;
using DockerDemo.Logic.IServices;
using DockerDemo.Logic.Services;
using System.Diagnostics.CodeAnalysis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
RepositoryDL(builder.Services);
ServiceDL(builder.Services);
ExternalServiceDL(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



[ExcludeFromCodeCoverage]
void RepositoryDL(IServiceCollection services)
{
    services.AddScoped<IWelcomeRepo, WelcomeRepo>();
    //services.AddScoped<IIntegrationToolsRepository, IntegrationToolsRepository>();
    //services.AddScoped<IPayrollTemplateRepository, PayrollTemplateRepository>();
    //services.AddScoped<IMasterToolColumnsRepository, MasterToolColumnsRepository>();
    //services.AddScoped<IMasterMewurkFieldsRepository, MasterMewurkFieldsRepository>();
    //services.AddScoped<IMasterColumnFieldMappingRepository, MasterColumnFieldMappingRepository>();
    //services.AddScoped<IToolPayrollTemplateMappingRepository, ToolPayrollTemplateMappingRepository>();
    //services.AddScoped<IPayrollFilesExportRepository, PayrollFilesExportRepository>();
    //services.AddScoped<ITemplateAssignmentRepository, TemplateAssignmentRepository>();
    //services.AddScoped<IEmployeeAssosciationRepository, EmployeeAssosciationRepository>();
    //services.AddScoped<IFileExportUpdateRepository, FileExportUpdateRepository>();
}


[ExcludeFromCodeCoverage]
void ServiceDL(IServiceCollection services)
{
    services.AddScoped<IWelcomeService, WelcomeService>();
    //services.AddScoped<IPayrollService, PayrollService>();
}


[ExcludeFromCodeCoverage]
void ExternalServiceDL(IServiceCollection services)
{
    //services.AddScoped<IExternalEmployeeService, ExternalEmployeeService>();
    //services.AddScoped<IExternalUserService, ExternalUserService>();
    //services.AddScoped<IExternalLeaveService, ExternalLeaveService>();
    //services.AddScoped<IExternalAttendanceService, ExternalAttendanceService>();
    //services.AddScoped<IExternalDocumentService, ExternalDocumentService>();
    //services.AddScoped<IExternalAuditLogService, ExternalAuditLogService>();
}
