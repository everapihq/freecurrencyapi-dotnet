# freecurrencyapi-dotnet

freecurrencyapi-dotnet is the official C# package for [freecurrencyapi](https://app.freecurrencyapi.com).

## Configuration

You will need your apikey to use fxapi, you can get
one [https://app.freecurrencyapi.com/register](https://app.fxapi.com/register).

Create an instance and pass your api key like here:

    var fx = new Freecurrencyapi("[YOUR_API_KEY]");

## Usage & Endpoints

Use the instance to call the endpoints

#### Status

Returns your current quota

    fx.Status()

#### Currencies

Returns all our supported currencies

    fx.Currencies(currencies)

| Parameter  | Data type | Mandatory | Description |
------------| --- | ----------- | --- | ----------- |
| currencies | string | no | A list of comma seperated currency codes which you want to get (EUR,USD,CAD). By default all available currencies will be shown |

#### Latest Exchange Rates

Returns the latest exchange rates. The default base currency is USD.

    fx.Latest(base_currency, currencies)    

| Parameter     | Data type | Mandatory | Description                                                                                                                     |
|---------------|-----------|-----------|---------------------------------------------------------------------------------------------------------------------------------|
| base_currency | string    | no        | By default all values are based on USD. By default all values are based on USD                                                  |
| currencies    | string    | no        | A list of comma seperated currency codes which you want to get (EUR,USD,CAD). By default all available currencies will be shown |

#### Historical Exchange Rates

Returns the latest exchange rates. The default base currency is USD.

    fx.Historical(date, base_currency, currencies)    

| Parameter     | Data type | Mandatory | Description                                                                                                                     |
|---------------|-----------|-----------|---------------------------------------------------------------------------------------------------------------------------------|
| date          | string    | yes       | Date to retrieve historical rates from (format: 2021-12-31)                                                                     |
| base_currency | string    | no        | By default all values are based on USD. By default all values are based on USD                                                  |
| currencies    | string    | no        | A list of comma seperated currency codes which you want to get (EUR,USD,CAD). By default all available currencies will be shown |

You can find further information on https://freecurrencyapi.com/docs/

## Contributing

1. Fork it
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Added some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create new Pull Request

Bug reports and pull requests are welcome on GitHub at https://github.com/everapihq/freecurrencyapi. This project is intended to
be a safe, welcoming space for collaboration, and contributors are expected to adhere to
the [code of conduct](https://github.com/everapihq/fxapi-dotnet//blob/master/CODE_OF_CONDUCT.md).

## License

The gem is available as open source under the terms of the [MIT License](https://opensource.org/licenses/MIT).

## Code of Conduct

Everyone interacting in the fxapi project's codebases, issue trackers, chat rooms and mailing lists is expected to
follow the [code of conduct](https://github.com/everapihq/freecurrencyapi-dotnet/blob/master/CODE_OF_CONDUCT.md).
