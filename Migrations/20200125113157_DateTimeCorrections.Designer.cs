﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using weatherMvc.Data;

namespace weatherMvc.Migrations
{
    [DbContext(typeof(WeatherMvcDbContext))]
    [Migration("20200125113157_DateTimeCorrections")]
    partial class DateTimeCorrections
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("weatherMvc.Models.Alert", b =>
                {
                    b.Property<int>("alertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("weatherDataId")
                        .HasColumnType("int");

                    b.HasKey("alertId");

                    b.HasIndex("weatherDataId");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("weatherMvc.Models.AlertData", b =>
                {
                    b.Property<int>("alertDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expires")
                        .HasColumnType("datetime2");

                    b.Property<string>("severity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("alertDataId");

                    b.ToTable("AlertData");
                });

            modelBuilder.Entity("weatherMvc.Models.AlertRegion", b =>
                {
                    b.Property<int>("alertRegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("alertDataId")
                        .HasColumnType("int");

                    b.Property<string>("regions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("alertRegionId");

                    b.HasIndex("alertDataId");

                    b.ToTable("AlertRegions");
                });

            modelBuilder.Entity("weatherMvc.Models.Currently", b =>
                {
                    b.Property<int>("currentlyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("apparentTemperature")
                        .HasColumnType("float");

                    b.Property<double>("cloudCover")
                        .HasColumnType("float");

                    b.Property<double>("dewPoint")
                        .HasColumnType("float");

                    b.Property<double>("humidity")
                        .HasColumnType("float");

                    b.Property<string>("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("nearestStormDistance")
                        .HasColumnType("float");

                    b.Property<double>("ozone")
                        .HasColumnType("float");

                    b.Property<double>("precipIntensity")
                        .HasColumnType("float");

                    b.Property<double>("precipIntensityError")
                        .HasColumnType("float");

                    b.Property<double>("precipProbability")
                        .HasColumnType("float");

                    b.Property<string>("precipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("pressure")
                        .HasColumnType("float");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("temperature")
                        .HasColumnType("float");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<int>("uvIndex")
                        .HasColumnType("int");

                    b.Property<double>("visibility")
                        .HasColumnType("float");

                    b.Property<int>("windBearing")
                        .HasColumnType("int");

                    b.Property<double>("windGust")
                        .HasColumnType("float");

                    b.Property<double>("windSpeed")
                        .HasColumnType("float");

                    b.HasKey("currentlyId");

                    b.ToTable("Currently");
                });

            modelBuilder.Entity("weatherMvc.Models.Daily", b =>
                {
                    b.Property<int>("dailyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dailyId");

                    b.ToTable("Daily");
                });

            modelBuilder.Entity("weatherMvc.Models.DailyData", b =>
                {
                    b.Property<int>("dailyDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("apparentTemperatureHigh")
                        .HasColumnType("float");

                    b.Property<DateTime>("apparentTemperatureHighTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("apparentTemperatureLow")
                        .HasColumnType("float");

                    b.Property<DateTime>("apparentTemperatureLowTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("apparentTemperatureMax")
                        .HasColumnType("float");

                    b.Property<DateTime>("apparentTemperatureMaxTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("apparentTemperatureMin")
                        .HasColumnType("float");

                    b.Property<DateTime>("apparentTemperatureMinTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("cloudCover")
                        .HasColumnType("float");

                    b.Property<int?>("dailyId")
                        .HasColumnType("int");

                    b.Property<double>("dewPoint")
                        .HasColumnType("float");

                    b.Property<double>("humidity")
                        .HasColumnType("float");

                    b.Property<string>("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("moonPhase")
                        .HasColumnType("float");

                    b.Property<double>("ozone")
                        .HasColumnType("float");

                    b.Property<double>("precipIntensity")
                        .HasColumnType("float");

                    b.Property<double>("precipIntensityMax")
                        .HasColumnType("float");

                    b.Property<DateTime>("precipIntensityMaxTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("precipProbability")
                        .HasColumnType("float");

                    b.Property<string>("precipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("pressure")
                        .HasColumnType("float");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("sunriseTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("sunsetTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("temperatureHigh")
                        .HasColumnType("float");

                    b.Property<DateTime>("temperatureHighTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("temperatureLow")
                        .HasColumnType("float");

                    b.Property<DateTime>("temperatureLowTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("temperatureMax")
                        .HasColumnType("float");

                    b.Property<DateTime>("temperatureMaxTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("temperatureMin")
                        .HasColumnType("float");

                    b.Property<DateTime>("temperatureMinTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<int>("uvIndex")
                        .HasColumnType("int");

                    b.Property<DateTime>("uvIndexTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("visibility")
                        .HasColumnType("float");

                    b.Property<int>("windBearing")
                        .HasColumnType("int");

                    b.Property<double>("windGust")
                        .HasColumnType("float");

                    b.Property<DateTime>("windGustTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("windSpeed")
                        .HasColumnType("float");

                    b.HasKey("dailyDataId");

                    b.HasIndex("dailyId");

                    b.ToTable("DailyData");
                });

            modelBuilder.Entity("weatherMvc.Models.FlagSource", b =>
                {
                    b.Property<int>("flagSourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("flag_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("flagsId")
                        .HasColumnType("int");

                    b.HasKey("flagSourceId");

                    b.HasIndex("flagsId");

                    b.ToTable("FlagSources");
                });

            modelBuilder.Entity("weatherMvc.Models.Flags", b =>
                {
                    b.Property<int>("flagsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("neareststation")
                        .HasColumnType("float");

                    b.Property<string>("units")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("flagsId");

                    b.ToTable("WeatherFlags");
                });

            modelBuilder.Entity("weatherMvc.Models.Hourly", b =>
                {
                    b.Property<int>("hourlyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("hourlyId");

                    b.ToTable("Hourly");
                });

            modelBuilder.Entity("weatherMvc.Models.HourlyData", b =>
                {
                    b.Property<int>("hourlyDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("apparentTemperature")
                        .HasColumnType("float");

                    b.Property<double>("cloudCover")
                        .HasColumnType("float");

                    b.Property<double>("dewPoint")
                        .HasColumnType("float");

                    b.Property<int?>("hourlyId")
                        .HasColumnType("int");

                    b.Property<double>("humidity")
                        .HasColumnType("float");

                    b.Property<string>("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ozone")
                        .HasColumnType("float");

                    b.Property<double>("precipIntensity")
                        .HasColumnType("float");

                    b.Property<double>("precipProbability")
                        .HasColumnType("float");

                    b.Property<string>("precipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("pressure")
                        .HasColumnType("float");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("temperature")
                        .HasColumnType("float");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.Property<int>("uvIndex")
                        .HasColumnType("int");

                    b.Property<int>("visibility")
                        .HasColumnType("int");

                    b.Property<int>("windBearing")
                        .HasColumnType("int");

                    b.Property<double>("windGust")
                        .HasColumnType("float");

                    b.Property<double>("windSpeed")
                        .HasColumnType("float");

                    b.HasKey("hourlyDataId");

                    b.HasIndex("hourlyId");

                    b.ToTable("HourlyData");
                });

            modelBuilder.Entity("weatherMvc.Models.Minutely", b =>
                {
                    b.Property<int>("minutelyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("minutelyId");

                    b.ToTable("Minutely");
                });

            modelBuilder.Entity("weatherMvc.Models.MinutelyData", b =>
                {
                    b.Property<int>("minutelyDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("minutelyId")
                        .HasColumnType("int");

                    b.Property<double>("precipIntensity")
                        .HasColumnType("float");

                    b.Property<double>("precipIntensityError")
                        .HasColumnType("float");

                    b.Property<double>("precipProbability")
                        .HasColumnType("float");

                    b.Property<string>("precipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.HasKey("minutelyDataId");

                    b.HasIndex("minutelyId");

                    b.ToTable("MinutelyData");
                });

            modelBuilder.Entity("weatherMvc.Models.WeatherData", b =>
                {
                    b.Property<int>("weatherDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("currentlyId")
                        .HasColumnType("int");

                    b.Property<int?>("dailyId")
                        .HasColumnType("int");

                    b.Property<int?>("flagsId")
                        .HasColumnType("int");

                    b.Property<int?>("hourlyId")
                        .HasColumnType("int");

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<double>("longitude")
                        .HasColumnType("float");

                    b.Property<int?>("minutelyId")
                        .HasColumnType("int");

                    b.Property<int>("offset")
                        .HasColumnType("int");

                    b.Property<string>("timezone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("weatherDataId");

                    b.HasIndex("currentlyId");

                    b.HasIndex("dailyId");

                    b.HasIndex("flagsId");

                    b.HasIndex("hourlyId");

                    b.HasIndex("minutelyId");

                    b.ToTable("WeatherData");
                });

            modelBuilder.Entity("weatherMvc.Models.Alert", b =>
                {
                    b.HasOne("weatherMvc.Models.WeatherData", null)
                        .WithMany("alerts")
                        .HasForeignKey("weatherDataId");
                });

            modelBuilder.Entity("weatherMvc.Models.AlertRegion", b =>
                {
                    b.HasOne("weatherMvc.Models.AlertData", null)
                        .WithMany("alert_regions")
                        .HasForeignKey("alertDataId");
                });

            modelBuilder.Entity("weatherMvc.Models.DailyData", b =>
                {
                    b.HasOne("weatherMvc.Models.Daily", null)
                        .WithMany("daily_data")
                        .HasForeignKey("dailyId");
                });

            modelBuilder.Entity("weatherMvc.Models.FlagSource", b =>
                {
                    b.HasOne("weatherMvc.Models.Flags", null)
                        .WithMany("flag_sources")
                        .HasForeignKey("flagsId");
                });

            modelBuilder.Entity("weatherMvc.Models.HourlyData", b =>
                {
                    b.HasOne("weatherMvc.Models.Hourly", null)
                        .WithMany("hourly_data")
                        .HasForeignKey("hourlyId");
                });

            modelBuilder.Entity("weatherMvc.Models.MinutelyData", b =>
                {
                    b.HasOne("weatherMvc.Models.Minutely", null)
                        .WithMany("minutely_data")
                        .HasForeignKey("minutelyId");
                });

            modelBuilder.Entity("weatherMvc.Models.WeatherData", b =>
                {
                    b.HasOne("weatherMvc.Models.Currently", "currently")
                        .WithMany()
                        .HasForeignKey("currentlyId");

                    b.HasOne("weatherMvc.Models.Daily", "daily")
                        .WithMany()
                        .HasForeignKey("dailyId");

                    b.HasOne("weatherMvc.Models.Flags", "flags")
                        .WithMany()
                        .HasForeignKey("flagsId");

                    b.HasOne("weatherMvc.Models.Hourly", "hourly")
                        .WithMany()
                        .HasForeignKey("hourlyId");

                    b.HasOne("weatherMvc.Models.Minutely", "minutely")
                        .WithMany()
                        .HasForeignKey("minutelyId");
                });
#pragma warning restore 612, 618
        }
    }
}
