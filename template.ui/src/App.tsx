import { useEffect, useState } from "react";

function App() {

  const [first, setFirst] = useState([]);

async function users() {

  const response = await fetch('http://localhost:5286/users').then(response => response.json());
setFirst(response);
  return response;
}
useEffect(() => {
users();
},[])

  return <div>
{first.map((user: any) => <p key={user.id}>{user.name}</p>)}
  </div>;
}

export default App;
