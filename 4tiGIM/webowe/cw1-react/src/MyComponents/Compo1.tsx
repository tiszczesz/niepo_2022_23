
const Compo1 = () => {
    const d = new Date();
    return (
        <div>
            <p>
                Lorem ipsum dolor sit amet consectetur, adipisicing elit. Optio atque quasi magni! Porro, quia quidem, omnis voluptate quo rerum ex quos culpa quod sequi molestias? Quidem consectetur harum fugiat accusamus?
            </p>
            <p>{d.toLocaleDateString()}</p>
        </div>
    )
}

export default Compo1;