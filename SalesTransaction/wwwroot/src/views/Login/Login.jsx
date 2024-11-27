import React,{useState}from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import axios from 'axios';

const Login = () => {
    const [userName,setUserName]=useState("");
    const [password,setPassword]=useState("");
    const Clear=()=>{
        setUserName("");
        setPassword("");
    }
   
  return (
    <>

      <div className="container-fluid" style={{ height: "100vh" }}>
        <div className="container h-75 ">
          <div className=" d-flex flex-column h-100 justify-content-center ">
            <h1 className="text-center">
              Sales Transaction Production Interface
            </h1>
            <div className="d-flex justify-content-center w-100 ">
              <form className="w-50 mt-5 ms-5  ">
                <div className="d-flex gap-3">
                  <div className="d-flex flex-column gap-3 justify-content-start">
                    <label className="fs-5">User Name:</label>
                    <label className="fs-5 pt-3">Password:</label>
                  </div>
                  <div className="d-flex flex-column gap-3 justify-content-start">
                    <input
                      className=" border-2 rounded-3 p-2"
                      type="email" value={userName} autoComplete="off"
                      onChange={(e)=>setUserName(e.target.value)}   
                      placeholder="example@email.com"
                    ></input>
                    <input
                      className="border-2 rounded-3 p-2"
                      type="password" value={password} autoComplete="off"
                      onChange={(e)=>setPassword(e.target.value)}
                      placeholder="***"
                    ></input>
                  </div>
                </div>
                <div className="d-flex w-75 mt-5 justify-content-around">
                  <button className="btn fs-5 btn-success">Submit</button>
                  <button className="btn fs-5 btn-danger"onClick={Clear}>Clear</button>
                  <button className="btn fs-5 btn-secondary">
                    Reset Password
                  </button>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default Login;
