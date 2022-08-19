﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eco1.Server.Data;

#nullable disable

namespace eco1.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220819123125_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eco1.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "jknkjn ihoi joij omij moi m io",
                            ImageURL = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAoHCBYWFRgVFRYYGBgYGBgYGBgYGBgYGBgSGBgZGRkYGBgcIS4lHB4rIRgYJjgmKy8xNTU1GiQ7QDs0Py40NTEBDAwMEA8QHxISHjQjJCQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NP/AABEIALcBFAMBIgACEQEDEQH/xAAbAAABBQEBAAAAAAAAAAAAAAAEAAIDBQYBB//EADwQAAIBAgQDBgQEBAUFAQAAAAECAAMRBBIhMQVBUQYiYXGBkROhsfAyUsHRI0KC4QcUYnKiU5KywvEz/8QAGgEAAgMBAQAAAAAAAAAAAAAAAgMAAQQFBv/EACsRAAICAQQBAwQBBQEAAAAAAAABAhEDBBIhMUEiMlEFE2FxkSNCgbHwFP/aAAwDAQACEQMRAD8A8+qcTE7Txt9xKYm0mpVYCQui7Uq0iq4VTAFq9IQlYybQaIquEEDq4W0uFa8Y9O8llpsz7AicDSwxWFMr2Ugwg0zW9kMZuhPOX3FU2aYTgeIyVB4z0TEDPTv4RclyPxvgrMSM1M+Uw1dLMR4zd0NUImO4nTy1CJcQMiA1aSq9tYzLGkwxRZJiLi0t+H0QNbSi4ZTzN5TVYLCltBoBuf0HUxM5qPYSxzyyUIK2yS86plpSwCgbZj46/KGgW0AHpeZpaqPhHTxfQptXOSX65M67GRFppSPDykb8PR9GUDxXQ3/WVHVJvlBZfobjG4St/lGYd5E+LAh/E+zVYAtSPxAN1Oj+nJvkfCZ0YdrkNcHmDoR5iaozjJWmcfLpZ4nU1RJiceToJVVqjGEV1sYO2sZ2Co0D3iYRzJOGSgxqiOyzqLJgkpshCFjGSHIkVSlpB3UVYAFheHe8FqQnAjUXhvoOLCHpHoZPQS2stnVcglZVcWMGw5Lga+K1nJXO2s7KFUiItOqJIKceqQytyGA2knxY/IJz4cuyrOJirQynxEQFqUHenKLTTLh8Wh6QPEBW2leREptLotId+FgRym+4NxANTsTymFVM0s8KxUaGC+QlPaaNcWqkiZ3iwzvcRzMSbzktIF5GyuZDIGQy4KCNFEEgAan6yMkeXQ/s5hmZjN7h6FksOXlK/huEWmiqNzqT/q5kwxMSFNr7sPnvvOXny75cdHr9Dof/ADw3P3Pv8BlMEmzbff8AaTNT8pKaQ0PP9omWK20aHK3wRU6d9pKtMD/7HKbbRHe/3vKKcm2Sg6bdf3lXxjhqVV1GWpbuvY3sL6N1EMNX6+33pB8RVJGmhte/vp7RkJNO0JngWSLjJWmeZY9SrMrCzKSCOhEDzTQds8PlqK42ZSp/3KbXPmpUekzU6cHcbPK58X2puHwPM6yaRKJLfSGJIaYhSrBucJpGCymPVY9luJwSRRFsAqcStjOUKlveHYulpK5BYxsXaGxZpaNTMvpAMStpa8Kw90BtylZxE2NoI59FeRFHxSxdHA87ng+aLNCFUEh50PBs06GkJQVeRssarR+aUUDukjtCKhioJcwrDJsNThgSMVLSW8sW2RxFo5hIXBgsiVjy0seCUM75jsNB/uP9pTfFmw4Rh8iKDvqT/uMz6ie2FfJ1fpOm+7nUpdLn/IbVJUfdpU1sWc2up676+Escat12/TSZ7FNrpp99Zhxx3Hs5tRjZ6RhqoZFbqob3Gxg9atY/ekqeyuNz0SjHVGsL75GFx8w0I4hXAPhzv5bS5xp0YsUdzDkfXwj2qfftAMHig9tN1vfxDEfpJa72++W0Cg3D1UMerqfv73MiNYH+3lBsQ/Ndf02jMLTJ3+7Hr6GWkO2pIE7R4bPRPIr31vv3V73uCflMR8KelOf5SBaxB6XNr/K8whSxI6Ej20m/Ty9NHlfrOPbkUl5AhTMf8Mwm05NRxrBDSktNbSa0YzgQWrImSCPQwcVhJA0W4kaJXW4lVVSzSyzwbEJcyo8MuPDNdwQA0vSZji5/iGaTs9UGS0puM4TvloS7NM36UyqA8IppOH4EFAYpdoEx152RR6xguh0kWR2nA0qiqClnTBxUnRUlUWoo6zSXDVLGQtGyFB74sTgxV4DadU2kLoPTE6i8tRRDLMyzy74Pir90ymg4pJjcJgS1ZF5ZrnyXX9Js6IBOn7QHAUAGZ+i29T/8llhqf30nO1U7dfB6j6RiUcTl8sFxd7HW33vKDEJrpNNjKVxY+/Pr7TPYpLEgDzvvfnAxPk6ebmDoJ7PV8lXXZ+4fMm6/O3vNFj6dxe3z/aZG1lmr4RjhWphj+Id1x/qHP1Fj6npHZIutxxtJrLzyxvx0E9lMKr5g2YlQgUKNe8wBa1xoLqSegbSDcUJp1CjHUeYzA7MAeRhfCVFOuupCswRiCQcrCym48Wv6S27V9mi6K1I5npg5QT3nBOZlbQC+tx6wIw3xteDVLULFqfU/TJfwzOJQzbdPleHphwq2try8r32ldgMSALMdfp6cpapigFJ35Ab3NtvDnFrs1ZZvwB4hMqE6b3I8t/kJgApOvrNhxfGFaLsPye1zl/WYdscJuwRpNnmvq898lFeLCMs7l6wBsbInxRM0HH2MLxFcCAmreRsxM4JA0qJQYUjwQGSI8ogUphuDw4eVyND8BUIbSVt+Sl2WmAolHI5GHY/DZh6SDCtdpYvBfZrjH00DcOpMEAik3xgNIpCbUec5Z1RO2itHGcfG5YrxZoII1qcSLHlpwGQIRnI+ROZCqFmnbRqmTCQsjyRUqhRriSkSPJIEjc8EqZqQb8xI9F0+t5fYdLD71lF2do/wKfiGPu7TSKo0E5Od3N/s9jo1twRX4IKinmB9kTO8TQZhY9b++k1NVLLpzmbx9PvEnrYfqBKx9jcs6xtlTj3yr6QbgXFTRq5jfI/dceF9G8x9CZzjFXlKyks6aS20zxUMkoZN67uz1LEurAG+hFrja/I39p6Rwd1eijHXMqljzzFRfXzni3ZnH5k+C/Idw9U6eY+nlPSOyWKYUWQkfw2INyPwNZlN+QuWHhaIxLZNxfk7Oqms+nU4+GWHF+zlGo2dl722dLq39RGh/qBlNV7PhVJSpmCjQOu+h0YqPLW2014xF1N9COW0Awz3zAm+a7DYkH8tv1jpRg30YsebNGPD4R5X2vwYpYR1vc56evm1x8gZ55lnpX+Ix7jDk9Sm2nQI4H0HtPPVURsargyZpSlK5dsg+HOGmYYDGVWFpBYKBFaNZ4leXRKHiOVpGZwGUU0EipJaNcg6QWPWUyUbHg9IvYw/E92A9mMQCAJY8VEU3ya4+0pcRie9OwWpTJN7RQuALM5ecvFO2jLMxyK0V4pRDk7aKcLSwjt5GxjiYhTJlpFIapkqxyUIQlKUSxipeP8Ah2kwW0jYymSLtnoeAoBFRfyooPmBrf1lqq6wHCLdz4WHzliBz6Tj5Hcj20ajCKXwQVR/f795m+Kgi9+QJ9Rf+00mI0v8z9T9Zm+NN3XPRD5/h0+/CHhXqBzv+jL9GOxtTM0kw9OQ01uZZYenOi2eLfBJh1KkEGxBuCNwZ6N2H4iXd76NlU25HIbbdDmB/pMxFKgbXh/BMcKOJouxspcI3+1+5r4XYH0k23yMwZnF7fD7PR6jknNTJygghdwKbXAFuVrEW6FYTWAUq6EaZXJPNCCLEdf7SjwuMyFidqLuHHWhfKx8ctlf+g9ZacQQIrDSy5gbG91a7IfK9/lM6fFnXlHa9v8AzTM5/iBw/OjgblGItvnS9RQPOzDyM8d+JPeu01bPTV7HLlR9RsFIJBPlces8L4rhlp1XRTcIxW/O4NiD5EH5TXB2jnZ41TB2qxjVCYwzhMYZxyiJhO045xIWJWnGjAZIJARyGSKZEslVTAZTL/s1Us9ppeK/hv4TN9mqZzGafiidz0ipdmjH7Spwr93bnFAqGKsCL8zFCJaMqGkim84VjkURgpI4yGMLQzS0FqJIRxGFp1EJjckPwyaQgJcDKeHhC0wJJFaCLbI8s6BH5YrSA2MYyIvrO1Wg7vvKGQ7PV8AtyTyubeOssNoLwtf4af7F98tzC3HTznImvUe0jK0v0B4ptydtf7zLdofwVLcwPX8Os0eMcj5D7+coq2CeuxpIBnfQXNhpqdfJWMbgXqB1fGB/pmYwFG5ltkCi8sa3AkwyfxqoZ/8Ap09T/Ux29pQYnFBr2FvC9/nN+13yeQ2/IVX4sqi0pcbjy+x15WgtYXYyMLGJFJUewYTFhqhqWBVznt1VwGt7PLrAtnw70tS9EPRN7nNTUK9Ik8zkZBfwaYXspic9JOq/wz/TbJ/xI9pqsLjcldkJ/wD2orofzotUFvMhkHoJirbJxPQSanjjNdqi3qorYOzkaEp/3NkUe5X3niXa2gVxLki2fK/q4Gb/AJBp7lQrKKTqrAjMQSLHW3h6TyHt9h8tRG6qynzDZ/8A3b2j8MukYNTHt+LMhaNMlIjCs0IwnFjrx6USY40rSm0DZARHLJLRAayWSywoYUZbmN+Ioh1RO5p0lIIPYb4Nd2WYMTpzml4qncPlM52PT6zUcR/CfKKl2OgvSecYtyHYeMUPr4fvHzihWBtZR1UkF4W0FZYwUhyvExjVjmQ22kCFT1MsadM22lbhh3po6NssjFyQIFncsmZNY1xKENjLQavVtH1qoAlfVa8gUYjHqExtjHKksuHcJqVzlpozdSB3R5tsJdpGiEbdJHqfDVtSpg75Ev55Re/zk7xwQCwG1vbS36SOofv79Jx5+6z12NcIGxCA2FuhH36GV/DaZ/zdIXIuxFxpYFWGh9/eWTrv98oHSfLiaLH/AKqexYLb5xuF1JE1CvE1+C+qcGQE5MOrnmz3Yk+sifhTk2OFpgHoE095qatY7QdgeZPlOg+erOAqS6Rk8T2OpP8Aio0weqnKfdZQ4z/Do3vTqWHRhm9iLT0GvignQfMwGpxPkBf0k3UD9pS5oyXB+z9TDFg7BldlK5bjvLmve/gR7QbjHGRSxqNlDhaZUj8vxD+IW/mAHsfGaXi2PCJ8R9lN8otc91jbwnk1fEs7tUY6s1+vja/gCB6QIw3TcmNy5VjwqEe7LzhXad6ACA3QlWdd9iM1vEgWlRx/ibYhy50BIsvIWW31v7yvl32e4GMTnUvkKKrKbAgsxIAPhoY9qN2YN05LbdmfVCZMlIDeWvFuz+Iw2rLmT86arbx5iUbVCZGKcX0WIZQJX121jLmMIMpRoqh2aOTUgRmUyy4Rhczay2XFW6LlKf8AC16TNN+I+c2eJo2TKOkzWM4eV70GI3IjUdjk7gMu8e+4lb2XSyDyjsfXsTFPsbHhIqMYe8YpX4zEd8xQqBsrFF5ImCJM7Ra28c+PA23jBMaJKeDUbwwYdLSmfGM20fh6zEyUy9yQecIAbx1N7G0dTvbWRVRJ4ESlcgqvWAErK2KJ2nalzGLSkSIkiBrneOSnc2Hp5yYU5vuyvZsIBWrDvbqp/lv1/wBUCc1FWzTp8Es0tsevLK/s/wBjL2fEbbimOnLOf0E9E4XhEWm2UABb7Cw0G0Dz32hi1SEKjQAH1Yi1/nMf3nJ2zux00cUaiufkrVBvr4GR1/rJl/aQ1NTY9f0mVo6Mexqr18pSYokV0O38SnbyDjX3J9pfMu0o+JrZ0b/UG9mFo3F7isjuDPSa9RVvrKrE4/kDK7E8VBPU+GsiTE32BHtOmpp9Hn3hkuwpnB6exgtd2XUWHpp9ZKaoG5lXjXVjYAH3EXklSH4IXLp0VvaPF5qDi4O5uBb+Vv3nnbnQDzPubfpN52hw+XDO3l15gzD10s4XoqA+eRSfmZeFtx5Ea+MVNJdURgTbdiaSrTdmv32AFvyICP8AyZvaZBKDO6oguzEKo6sdp6tguGpTprTtfKoW9zckbt6m59ZMz9NIrRQTnufSHqoI7rg/6W5+hmW4/wBj85L0gEbmv8jHqPyma5KKr4jo1j84XSQfyW8rkfLaKxya8mrPijLxZ4nieGVKZIdGW2lyO76HaR/Bnttamh0dB6i4lJj+y+GqXyjI3VNr+I2mhSvycvLp5LlHlhSXXZqldiYbxbspWpXYDOn5l3A8RO9naVveRsRFNSplnjk1AkGMwmZIRjm70Ow1HMspGhqyHhtPInkJQcTxWpmgx9QItpiOJVbkwUuSSdICxFa7ExSHNFGCtxYPTldVTWXzUYDiaNoKkKi2BpTh+Coc4IoJNpcYZLCHZU2PIkTLeStOWligf4ca4k1QS87KcH+I/wAVxdEOg/M4/QfWBOahG2PwYZZZKK8hXZLs6SwrVV0GqIevJmH0E2rUjsNhv5yxwWE7uY6ftBcTUGy7cz1MxZLat+T0WnhHGtkPHbBGGWKpX7pA52v73/SNYjnr4CR19LC29/2H1iEbaTqxIPp85Gy6+H6yU7SL79IAaOVD+kpeKj63/wCK29N5a1/v5mVPFVAs3QD2/D+sZj7CkvSTs/T9o5ah6wGnc8+QhKJ1tH2Y9vySlid5PhsOCfxAec5SUdPnCrLbQWkq+WROlSKntNRvh2UMDmZF0ufxNl6eM89qENVduQZre+nyE9G4ohKOADcAMtt8yEMLe1vWYLAcKqVDlUG7HvNbRV6k+5t4zRhktrs52txSc1XNmg7G4DX/ADDrfdaY8dmb/wBR/V4Td4cK/wCFteh3lHRXIqqq2VQFA8ALR/xBy0MyTzNy5XB08WjUYJJ8l22HYbiQuhGo0Mgw3F3TR+8vXnLijikqC4t6Qo7ZdOmKmsmP3K0A0cVfutvFUpX1XQ/KFYjCq228Hpoy6HaNSkuH/Ihyi+Vx+CNK+tm/tAsTwtCS6AK25A2aWGJo3F/eCZyDY+hhqTXDEzwxkrj/AAZHiTkPYixvLfAVhlEK4rw9ay9HXY9fAyioMUup0I3EO+DI4OL5O8cfQzEY19Zq+L1rrMdXe5hR5ETIcs7FmnZYngulxgJtC3pBlvM/UNmltg6+loDiWiJKIzQ8mwkaC5vHOIcRc1bEXvHokagkywgBn+XZ3VFF2YhQPE6T1Lh3DRSRKY2UAE9TzPqdZm+x/C7suIfqQg+TP+gmxr1dbj08pkzTUuPg7egwyhHc1y/9EuIxGmVdANz1PSVtQX2jydLt6CDPWLXA0A59T08pnb3dnUxx2rgjqV8psurfIecYmp1uTuT4SMUwD584QTa0BqkOXY6ob7fdoM429Y9uch6eesWNiqHNT08hb12lPxFwQeW//hLKvWsvjqfneUnEBoPE/Ij9hGQXqLlai2yamsKRBzgyAiShj4TTSMLbYYGA208I5cUeg9/0MHRCZOtK3OC2XFJdjWfNyFvaOWmPsyOtTPWJL23iZ2ujRjqghaCt/NY+P9pBiMA42s3kf3nPifYk9PEwFK+JIY1JcxZWNUZTZgfX95Nh8QVOZDbqJYuiuLaesq8ThCm23SW1XMS1NS9MuDQ4TGhxvY/WELW5GZKlXKm4l5QxAdb84/HlbMOfTpO/DLW4Ph9DAcRS5EaRUMTyMJc6dR9JpTUkYZJwZVgG197fMfvKfj2FLpnT8ajb8wHLzl+Uy+IMGqUxe/I/JuslUBOpKmeYYnGMwsZVsk1nazhJU/FQaE98DkfzeUy14UejmzjKMqZFlik2kUKwCXFgAyFapiilx6L8Frww3lg9OKKWhUuyBktLPgmC+NUWnsDqx8BvFFBnwmFgSllSfyekYXDBQABYAWAHISTLcxRTAenA8VUHLYCVdXEkjKNL7/oJyKDI04kmSUFJI8ISdheKKA+g/wC4jqm+vlIGvy+yYooA2PRAzaa/lv8AX95T4wEsPvp/eKKNx9g5vaOFUiSpcxRR7MSDaI9DJ1qk6fOKKLkHEf8AEtuIXRyndQYopRbJWwNMi4BB8CYFUwQB0PvORQpRQEJysHY5f2hCVQwsYoolcSNEuUA4vDW1G0iwlYq3gYooTSUik28bstKh5iG4GvmFjFFNGP3GDMltI62hty5SIjScimhGNkFRAwIIv5zM8X7LI12TuHcgbRRSn2HCEZr1GWq8JqKbae4iiilbmJenhZ//2Q==",
                            Price = 99.9m,
                            Title = "jbkbkj kjbkj b kjbk jbkjb"
                        },
                        new
                        {
                            Id = 2,
                            Description = "jknkjn ihoi joij omij moi m io",
                            ImageURL = "https://www.visitdubai.com/-/media/gathercontent/article/t/top-rides-at-img-worlds-of-adventure/media/top-rides-at-img-worlds-of-adventure-predator-5.jpg?rev=f1bb54a15add49a09c912eac851f4ff7&cx=0.56&cy=0.4&cw=1556&ch=690",
                            Price = 99.9m,
                            Title = "jbkbkj kjbkj b kjbk jbkjb"
                        },
                        new
                        {
                            Id = 3,
                            Description = "jknkjn ihoi joij omij moi m io",
                            ImageURL = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fguide-in-dubai.com%2Fwp-content%2Fuploads%2F2020%2F05%2FIMG-Worlds-of-Adventure-guide-in-dubai.jpeg&imgrefurl=https%3A%2F%2Fguide-in-dubai.com%2Fproduct%2Fimg-worlds-of-adventure%2F&tbnid=OmEuLe5xgrt5hM&vet=12ahUKEwjuxs7W9Ln5AhX7YvEDHboyCEwQMygHegUIARDHAQ..i&docid=XQKSKdMSyj_XBM&w=1500&h=1000&q=img&ved=2ahUKEwjuxs7W9Ln5AhX7YvEDHboyCEwQMygHegUIARDHAQ",
                            Price = 99.9m,
                            Title = "jbkbkj kjbkj b kjbk jbkjb"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
