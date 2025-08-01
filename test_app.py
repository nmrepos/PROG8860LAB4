from HelloWorld import app
import azure.functions as func

def test_main():
    req = func.HttpRequest(method='GET', url='/api/hello', body=None)
    resp = app.main(req)
    assert resp.status_code == 200
    assert resp.get_body().decode() == "Hello, world!"
