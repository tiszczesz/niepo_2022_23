

import './App.css';
import MyComponent from './MyComponent';
import MyComponent2 from './MyComponent2';
import MyComponent3 from './MyComponent3'

type Props = {}
function App(props: Props) {
  return (
    <>
      <MyComponent napis='To jest property ale trochę zmienione' />
      <MyComponent2 date={new Date()} price={56.99} />
      <MyComponent3 result={34+9} />
    </>

  );
}

export default App;
