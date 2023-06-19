select CurrencyRateDate,FromCurrencyCode,ToCurrencyCode,AverageRate
from Sales.CurrencyRate
where datepart(year,CurrencyRateDate)=2005 and ToCurrencyCode='GBP';

