# Contributing to the SDK

Please read `CONTRIBUTING.md` and `CODE_OF_CONDUCT.md`.

# Viewing the SDK documentation online

The SDK documentation is [available to view online](https://lusid-sdk-csharp.readthedocs.io/en/latest/).

# Building the SDK documentation locally as HTML

You can clone this repo and use Doxygen to build the SDK documentation and view it locally as HTML:
   
1. Change to this `docs` directory:

   `cd docs`

2. Install dependencies. For example, on Ubuntu:

   `sudo apt-get install doxygen graphviz`

3. Build the documentation:

   `doxygen`

4. Run a web server. For example, on Ubuntu:

   `python -m http.server`

5. View the doc set locally in a browser at:

   http://localhost:8000/html/

Note: Sphinx is used to build Doxygen for the purpose of hosting this documentation online at Readthedocs.
