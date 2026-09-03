.PHONY: all build test run

all: build test

build:
	@echo "Building billards..."
	@npm run build

test:
	@echo "Running test suites for billards..."
	@npm test

run:
	@echo "Starting billards..."
	@node server.js
