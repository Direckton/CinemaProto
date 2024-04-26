import { useEffect, useState } from "react";

const URL = 'http://localhost:8000/api/Movie';

export default function FetchMovies(){
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
  
  let movies;
  if(results!= null)
  {
    movies = results.map(u =>
      <div>
        <div>ID: {u.id}</div>
        <div>Name: {u.name}</div>
        <div>Duration: {u.duration}</div>
      </div>
    )
    
  }
  
  return (
    <div>{movies}</div>
  );
}