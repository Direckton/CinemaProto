import { useEffect, useState } from "react";

const URL = 'http://localhost:8000/api/User';

export default function Fetch(){
  const [results, setResults] = useState([]);
  
  useEffect(() => {
    async function getData() {
      const response = await fetch(URL);
      const data = await response.json();
      setResults(data);
    }
    
    getData();
    console.log(results, "results");
  }, []);
  
  let users;
  if(results!= null)
  {
    users = results.map(u =>
      <div>
        <div>ID: {u.id}</div>
        <div>Name: {u.name}</div>
        <div>E-mail: {u.email}</div>
        <div>Password: {u.password}</div>
      </div>
    )
    
  }
  
  return (
    <div>{users}</div>
  );
}