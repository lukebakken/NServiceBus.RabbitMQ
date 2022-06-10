﻿using System.CommandLine;
using NServiceBus.Transport.RabbitMQ.CommandLine;

var rootCommand = new RootCommand("A .NET global tool to manage the RabbitMQ transport for NServiceBus endpoints");
var delaysSubCommand = new Command("delays", "A set of commands that provide functionality realted to the delay infrastructure");

delaysSubCommand.AddCommand(DelaysCreateCommand.CreateCommand());
delaysSubCommand.AddCommand(DelaysMigrateCommand.CreateCommand());
delaysSubCommand.AddCommand(DelaysVerifyCommand.CreateCommand());

rootCommand.AddCommand(delaysSubCommand);

return await rootCommand.InvokeAsync(args).ConfigureAwait(false);