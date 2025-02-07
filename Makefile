# Yes, Im using make to build a dotnet project, deal with it.

all:
	dotnet build
	dotnet run

# I'm just used to using "make run" rather then just "make".
.PHONY: run
run: all

.PHONY: clean
clean:
	dotnet clean